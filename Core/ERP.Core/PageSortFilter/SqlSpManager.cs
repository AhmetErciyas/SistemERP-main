using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Core
{
    public class SqlSpManager
    {
        public static SqlPagedDAO<T> GetSPPagedResult<T>(DbConnection connection, string commandText, params SqlParameter[] parameters) where T : new()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            SqlPagedDAO<T> spSonuc = null;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = commandText;
                command.Connection = connection;

                if (parameters?.Length > 0)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                using (var dataReader = command.ExecuteReader())
                {
                    spSonuc = new SpManager<T>().DashboardDataMapper(dataReader);
                }
            }
            connection.Close();
            return spSonuc;
        }
    }

    public class SqlPagingValues
    {
        public int TotalCount { get; set; }
    }

    public class SqlPagedDAO<Tdata> where Tdata : new()
    {
        public List<Tdata> SpDataResult { get; set; }

        public List<SqlPagingValues> SpPaging { get; set; }
    }
    public class SpManager<Tdata> where Tdata : new()
    {
        public SqlPagedDAO<Tdata> DashboardDataMapper(DbDataReader reader)
        {
            var result = new SqlPagedDAO<Tdata>
            {
                // Result Set 1 - paging informations (bu alandaki parametrelerin yeri ile oynanmamalı!)
                SpPaging = reader.Translate<SqlPagingValues>(),

                // Result Set 2 - data
                SpDataResult = reader.Translate<Tdata>()
            };

            return result;
        }
    }

    public static class DataRecordExtensions
    {
        private static readonly ConcurrentDictionary<Type, object> _materializers = new ConcurrentDictionary<Type, object>();

        public static List<T> Translate<T>(this DbDataReader reader) where T : new()
        {
            var materializer = (Func<IDataRecord, T>)_materializers.GetOrAdd(typeof(T), (Func<IDataRecord, T>)Materializer.Materialize<T>);
            return Translate(reader, materializer, out var hasNextResults);
        }

        public static List<T> Translate<T>(this DbDataReader reader, Func<IDataRecord, T> objectMaterializer)
        {
            return Translate(reader, objectMaterializer, out var hasNextResults);
        }

        public static List<T> Translate<T>(this DbDataReader reader, Func<IDataRecord, T> objectMaterializer,
            out bool hasNextResult)
        {
            var results = new List<T>();
            while (reader.Read())
            {
                var record = (IDataRecord)reader;
                var obj = objectMaterializer(record);
                results.Add(obj);
            }

            hasNextResult = reader.NextResult();
            return results;
        }

        public static bool Exists(this IDataRecord record, string propertyName)
        {
            return Enumerable.Range(0, record.FieldCount).Any(x => record.GetName(x) == propertyName);
        }
    }

    public class Materializer
    {
        public static T Materialize<T>(IDataRecord record) where T : new()
        {
            var t = new T();
            foreach (var prop in typeof(T).GetProperties())
            {
                // 1). If entity reference, bypass it.
                if (prop.PropertyType.Namespace == typeof(T).Namespace)
                {
                    continue;
                }

                // 2). If collection, bypass it.
                if (prop.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(prop.PropertyType))
                {
                    continue;
                }

                // 3). If property is NotMapped, bypass it.
                if (Attribute.IsDefined(prop, typeof(NotMappedAttribute)))
                {
                    continue;
                }

                // If the property doesn't map to an existing field, just continue.
                if (!record.Exists(prop.Name)) continue;

                var dbValue = record[prop.Name];
                if (dbValue is DBNull) continue;

                if (prop.PropertyType.IsConstructedGenericType &&
                    prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    var baseType = prop.PropertyType.GetGenericArguments()[0];
                    var baseValue = Convert.ChangeType(dbValue, baseType);
                    var value = Activator.CreateInstance(prop.PropertyType, baseValue);
                    prop.SetValue(t, value);
                }
                else
                {
                    var value = Convert.ChangeType(dbValue, prop.PropertyType);
                    prop.SetValue(t, value);
                }
            }
            return t;
        }
    }
}
