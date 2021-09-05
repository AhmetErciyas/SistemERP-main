using ERP.Core.PageSortFilter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ERP.Core.Helpers
{
    public static class PageSortFilterHelper
    {
        #region Filter

        private static readonly MethodInfo Any = typeof(Enumerable).GetMethods(BindingFlags.Static | BindingFlags.Public).First(m => m.Name == "Any" && m.GetParameters().Count() == 2);
        private static readonly MethodInfo ListContains = typeof(Enumerable).GetMethods(BindingFlags.Static | BindingFlags.Public).First(m => m.Name == "Contains" && m.GetParameters().Count() == 2);
        private static readonly MethodInfo Contains = typeof(string).GetMethods().First(m => m.Name == "Contains" && m.GetParameters().Where(pi => pi.ParameterType == typeof(string)).Count() == 1);
        private static readonly MethodInfo StartsWith = typeof(string).GetMethods().First(m => m.Name == "StartsWith" && m.GetParameters().Where(pi => pi.ParameterType == typeof(string)).Count() == 1);
        private static readonly MethodInfo EndsWith = typeof(string).GetMethods().First(m => m.Name == "EndsWith" && m.GetParameters().Where(pi => pi.ParameterType == typeof(string)).Count() == 1);

        internal class ExpressionContainer
        {
            public Expression Expression { get; set; }
            public MethodInfo MethodInfo { get; set; }
            public ParameterExpression ParameterExpression { get; set; }
        }

        #region private static methods

        private static Expression HandleByFilterOperator(IFilterItem filterItem, MemberExpression expression)
        {
            return filterItem.Operator switch
            {
                FilterOperator.EqualTo => HandleEqualTo(expression, filterItem.Value),
                FilterOperator.Between => HandleBetween(expression, filterItem.Value, filterItem.Value2),
                FilterOperator.GreaterThan => HandleGreaterThan(expression, filterItem.Value),
                FilterOperator.LesserThan => HandleLesserThan(expression, filterItem.Value),
                FilterOperator.GreaterThanOrEqualTo => HandleGreaterThanOrEqualTo(expression, filterItem.Value),
                FilterOperator.LesserThanOrEqualTo => HandleLesserThanOrEqualTo(expression, filterItem.Value),
                FilterOperator.NotEqualTo => HandleNotEqualTo(expression, filterItem.Value),
                FilterOperator.Contains => HandleContains(expression, filterItem.Value),
                FilterOperator.StartsWith => HandleStartsWith(expression, filterItem.Value),
                FilterOperator.EndsWith => HandleEndsWith(expression, filterItem.Value),
                FilterOperator.ContainedIn => HandleContainedIn(expression, filterItem.Value.ToString().Split(",").ToArray()),
                _ => null,
            };
        }

        private static Expression HandleEqualTo(MemberExpression expressionLeft, object value)
        {
            return Expression.Equal(expressionLeft, GetConstantExpression(expressionLeft, value));
        }

        private static Expression HandleBetween(MemberExpression expressionLeft, object value1, object value2)
        {
            var expr1 = Expression.GreaterThanOrEqual(expressionLeft, GetConstantExpression(expressionLeft, value1));
            var expr2 = Expression.LessThanOrEqual(expressionLeft, GetConstantExpression(expressionLeft, value2));

            return Expression.And(expr1, expr2);
        }

        private static Expression HandleGreaterThan(MemberExpression expressionLeft, object value)
        {
            return Expression.GreaterThan(expressionLeft, GetConstantExpression(expressionLeft, value));
        }

        private static Expression HandleLesserThan(MemberExpression expressionLeft, object value)
        {
            return Expression.LessThan(expressionLeft, GetConstantExpression(expressionLeft, value));
        }

        private static Expression HandleGreaterThanOrEqualTo(MemberExpression expressionLeft, object value)
        {
            return Expression.GreaterThanOrEqual(expressionLeft, GetConstantExpression(expressionLeft, value));
        }

        private static Expression HandleLesserThanOrEqualTo(MemberExpression expressionLeft, object value)
        {
            return Expression.LessThanOrEqual(expressionLeft, GetConstantExpression(expressionLeft, value));
        }

        private static Expression HandleNotEqualTo(MemberExpression expressionLeft, object value)
        {
            return Expression.NotEqual(expressionLeft, GetConstantExpression(expressionLeft, value));
        }

        private static Expression HandleContains(MemberExpression expressionLeft, object value)
        {
            if (GetMemberExpressionType(expressionLeft) != typeof(string))
                return null;

            var constantExpression = GetConstantExpression(expressionLeft, value);
            return Expression.Call(expressionLeft, Contains, constantExpression);
        }

        private static Expression HandleContainedIn(MemberExpression expressionLeft, object[] values)
        {
            var constantExpression = GetConstantExpression(expressionLeft, values);
            return Expression.Call(GetMethodListContains(GetMemberExpressionType(expressionLeft)), constantExpression, expressionLeft);
        }

        private static Expression HandleStartsWith(MemberExpression expressionLeft, object value)
        {
            if (GetMemberExpressionType(expressionLeft) != typeof(string))
                return null;

            var constantExpression = GetConstantExpression(expressionLeft, value);
            return Expression.Call(expressionLeft, StartsWith, constantExpression);
        }

        private static Expression HandleEndsWith(MemberExpression expressionLeft, object value)
        {
            if (GetMemberExpressionType(expressionLeft) != typeof(string))
                return null;

            var constantExpression = GetConstantExpression(expressionLeft, value);
            return Expression.Call(expressionLeft, EndsWith, constantExpression);
        }

        private static Expression GetConstantExpression(MemberExpression expressionLeft, object value)
        {
            var safeValue = Convert.ChangeType(value, GetMemberExpressionType(expressionLeft));
            return NullableFix(expressionLeft, Expression.Constant(safeValue));
        }

        private static Expression GetConstantExpression(MemberExpression expressionLeft, object[] values)
        {
            var t = GetMemberExpressionType(expressionLeft);
            var listType = typeof(List<>).MakeGenericType(new[] { t });

            var safeValues = (IList)Activator.CreateInstance(listType);
            for (int i = 0; i < values.Length; i++)
                safeValues.Add(Convert.ChangeType(values[i], t));

            return Expression.Constant(safeValues, listType);
        }

        private static Expression NullableFix(MemberExpression memberExpression, Expression expression)
        {
            if (IsNullableType(memberExpression.Type))
                return Expression.Convert(expression, memberExpression.Type);

            return expression;
        }

        private static bool IsNullableType(Type t)
        {
            return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        private static Type GetMemberExpressionType(MemberExpression property)
        {
            var propertyInfo = ((PropertyInfo)property.Member);
            return Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
        }

        private static bool IsIEnumerable(Type t)
        {
            return typeof(IEnumerable).IsAssignableFrom(t);
        }

        private static MethodInfo GetMethodAny(Type t)
        {
            return Any.MakeGenericMethod(t);
        }

        private static MethodInfo GetMethodListContains(Type t)
        {
            return ListContains.MakeGenericMethod(t);
        }

        #endregion private static methods

        internal static Expression BuildFilterExpressionTree(Expression expression, IFilterItem filterItem)
        {
            Stack<ExpressionContainer> stack = new Stack<ExpressionContainer>();

            var expressionTemp = expression;
            MethodInfo methodInfo;
            ParameterExpression parameterExpression;

            // filterItem.FilterProperty değerini "." ile split ediyoruz, oluşan array uzunluğu, sorguda kaç seviye alta ineceğimizi gösteriyor
            //
            // Örnek ile açıklayalım:
            //
            // Giriş Entity'si A olsun (giriş entity bilgisi "expression" parametresinden gelmekte)
            // filterItem.FilterProperty = "Bs.C.Ds.D1",
            // filterItem.Operator = "EqualTo"
            // filterItem.Value = "Hello World" olsun
            //
            // class A
            // {
            //      ICollection<B> Bs { get; set; }
            // }
            // class B
            // {
            //      C C { get; set; }
            // }
            // class C
            // {
            //      ICollection<D> Ds { get; set; }
            // }
            // class D
            // {
            //      string D1 { get; set; }
            // }
            //
            // Yapılmak istenen;    A Entity'si altındaki
            //                          ICollection<B> (Bs) ler içerisinde
            //                              C (C) property'si altındaki
            //                                  ICollection<D> (Ds) ler içerisinde
            //                                      string (D1) değeri "Hello World"e eşit olan tüm A'ların listesini sorgulamak

            var inputProperties = filterItem.FilterProperty.Split(".");
            for (int i = 0; i < inputProperties.Length; i++)
            {
                methodInfo = null;
                parameterExpression = null;

                Expression property;
                if (IsIEnumerable(expressionTemp.Type))
                {
                    // Yukarıdaki örneğe göre oluşacak Property Expression'lar şu şekildedir:
                    // i=0 için: "A.Bs.Any(...)"
                    // i=2 için: "B.C.Ds.Any(...)"
                    var t = expressionTemp.Type.GetGenericArguments().SingleOrDefault();
                    methodInfo = GetMethodAny(t);
                    parameterExpression = Expression.Parameter(t, t.Name.ToLowerInvariant());
                    property = Expression.Property(parameterExpression, inputProperties[i]);
                }
                else
                {
                    // Yukarıdaki örneğe göre oluşacak Property Expression'lar şu şekildedir:
                    // i=1 için: "B.C"
                    // i=3 için: "D.D1"
                    property = Expression.Property(expressionTemp, inputProperties[i]);
                }

                stack.Push(new ExpressionContainer()
                {
                    Expression = property,
                    MethodInfo = methodInfo,
                    ParameterExpression = parameterExpression
                });

                expressionTemp = property;
            }

            // stack'i iterate ederek tüm Property Expression'larını birleştiriyoruz, filterItem.Operator'e göre filtreyi uyguluyoruz (HandleByFilterOperator methodu vasıtası ile).
            var expressionContainer = stack.Pop();

            ExpressionContainer exprOperationContainer = expressionContainer;
            expressionTemp = exprOperationContainer.Expression = HandleByFilterOperator(filterItem, (MemberExpression)expressionContainer.Expression);

            bool currentIsLambda = false;
            bool previousIsLambda = true;
            while (stack.Count > 0)
            {
                if (currentIsLambda)
                {
                    previousIsLambda = true;
                    currentIsLambda = false;
                }

                expressionContainer = stack.Pop();

                if (previousIsLambda && exprOperationContainer != null && exprOperationContainer.MethodInfo != null)
                {
                    var lambda = Expression.Lambda(exprOperationContainer.Expression, exprOperationContainer.ParameterExpression);
                    expressionTemp = Expression.Call(exprOperationContainer.MethodInfo, expressionContainer.Expression, lambda);
                    previousIsLambda = false;
                    exprOperationContainer = null;
                }

                if (expressionContainer.MethodInfo != null)
                {
                    exprOperationContainer = expressionContainer;
                    exprOperationContainer.Expression = expressionTemp;
                    currentIsLambda = true;
                }
            }

            // Yukarıdaki örneğe göre, iteration sonucunda oluşacak olan son Expression:
            // A.Bs.Any(B => B.C.Ds.Any(D => D.D1 = "Hello World")) olacaktır.
            return expressionTemp;
        }

        /// <summary>
        /// Sorgulara dinamik olarak Filtre ekler.
        /// </summary>
        /// <typeparam name="TEntity">Sorgu yapılan Entity</typeparam>
        /// <param name="filterItems">Filtre parametreleri</param>
        /// <returns></returns>
        public static Expression<Func<TEntity, bool>> GenerateFilterExpression<TEntity>(List<IFilterItem> filterItems)
        {
            if (filterItems != null && filterItems.Count > 0)
            {
                var expressions = new List<Expression>();
                var parameterEntity = Expression.Parameter(typeof(TEntity), typeof(TEntity).Name.ToLowerInvariant());

                foreach (var filterItem in filterItems)
                {
                    expressions.Add(BuildFilterExpressionTree(parameterEntity, filterItem));
                }

                Expression body = expressions[0];
                for (int i = 1; i < expressions.Count; i++)
                {
                    body = Expression.AndAlso(body, expressions[i]);
                }

                return Expression.Lambda<Func<TEntity, bool>>(body, parameterEntity);
            }

            return null;
        }

        #endregion Filter

        #region Sort

        private const string ORDERBY = "OrderBy";
        private const string ORDERBYDESCENDING = "OrderByDescending";
        private const string THENBY = "ThenBy";
        private const string THENBYDESCENDING = "ThenByDescending";
        private const string PARAMETER = "p";

        internal static IQueryable<TEntity> BuildSortQuery<TEntity>(IQueryable<TEntity> query, string sortProperty, bool ascending, bool thenBy)
        {
            var type = typeof(TEntity);
            var parameter = Expression.Parameter(type, PARAMETER);

            var inputProperties = sortProperty.Split('.');

            var propertyInfo = type.GetProperty(inputProperties[0]);
            var memberExpression = Expression.MakeMemberAccess(parameter, propertyInfo);

            for (int i = 1; i < inputProperties.Length; i++)
            {
                if (IsIEnumerable(propertyInfo.PropertyType))
                {
                    // TODO: Collection türü alt propertyler için Sort özelliği şu an çalışmıyor!!
                }
                else
                {
                    propertyInfo = propertyInfo.PropertyType.GetProperty(inputProperties[i]);
                    memberExpression = Expression.MakeMemberAccess(memberExpression, propertyInfo);
                }
            }

            var orderByExpression = Expression.Lambda(memberExpression, parameter);
            var resultExpression = Expression.Call(typeof(Queryable),
                                                    ascending ? (thenBy ? THENBY : ORDERBY) : (thenBy ? THENBYDESCENDING : ORDERBYDESCENDING),
                                                    new[] { type, propertyInfo.PropertyType },
                                                    query.Expression,
                                                    Expression.Quote(orderByExpression));

            return query.Provider.CreateQuery<TEntity>(resultExpression);
        }

        public static IQueryable<TEntity> GenerateSortQuery<TEntity>(IQueryable<TEntity> query, List<ISortItem> sortItems)
        {
            if (sortItems != null && sortItems.Count > 0)
            {
                for (int i = 0; i < sortItems.Count; i++)
                {
                    var sortItem = sortItems[i];
                    query = BuildSortQuery(query, sortItem.SortProperty, sortItem.Order == SortOrder.Asc, i != 0);
                }
            }

            return query;
        }

        #endregion Sort
    }
}