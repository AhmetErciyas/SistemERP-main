using ERP.Core;
using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Base;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ERP.Data
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<SqlPagedDAO<T>> GetStoreProcedure<T>(string spName, params SqlParameter[] parametre) where T : new();

        /// <summary>
        /// Get all entities from db
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Get all entities from db
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes);

        Task<List<TEntity>> GetAsyncWithIncludes(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includes);

        /// <summary>
        /// Get query for entity
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        Task<IQueryable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        /// <summary>
        /// Get first or default entity by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<TEntity> GetFirstOrDefaultAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes);

        Task<TEntity> GetFirstOrDefaultAsyncWithIncludes(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includes);

        Task<IQueryable<TEntity>> All(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includes);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null, params string[] includes);

        Task<TEntity> GetAsync<TIdentity>(TIdentity id, params Include[] includes);

        void Add(TEntity obj);

        void AddRange(List<TEntity> list);

        Task AddAsync(TEntity obj);

        Task AddRangeAsync(List<TEntity> list);

        Task UpdateAsync(TEntity obj);
        Task Update(TEntity obj);

        void UpdateRange(List<TEntity> list);

        Task DeleteAsync(byte id);

        Task DeleteAsync(short id);

        Task DeleteAsync(int id);

        Task DeleteAsync(long id);

        Task DeleteAsync(TEntity obj);

        Task<int> SaveChangesAsync();

        Task<PagedResult<TEntity>> GetPagedAsync(BasePagedSortFilterSearchDAO basePagedSortFilterDAO);
    }
}