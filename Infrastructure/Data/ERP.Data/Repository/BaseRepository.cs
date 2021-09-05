using ERP.Core;
using ERP.Core.Helpers;
using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Base;
using ERP.Data.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ERP.Data
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(DataContext context)
        {

            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task<SqlPagedDAO<T>> GetStoreProcedure<T>(string spName, params SqlParameter[] parametre) where T : new()
        {
            return SqlSpManager.GetSPPagedResult<T>(_dbContext.Database.GetDbConnection(), spName, parametre);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (Expression<Func<TEntity, object>> include in includes)
                query = query.Include(include);

            if (filter != null)
                query = query.Where(filter);

            int count = await Task.Run(() => query.Count());
            return count == 0 ? false : true;
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (Expression<Func<TEntity, object>> include in includes)
                query = query.Include(include);

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return await Task.Run(() => query.ToList());
        }

        public async Task<List<TEntity>> GetAsyncWithIncludes(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var include in includes)
                query = query.Include(include);

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return await Task.Run(() => query.ToList());
        }

        public async Task<IQueryable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return await Task.Run(() => query);
        }

        public async Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (Expression<Func<TEntity, object>> include in includes)
                query = query.Include(include);

            if (orderBy != null)
                query = orderBy(query);

            return await query.FirstOrDefaultAsync(filter);
        }

        public async Task<TEntity> GetFirstOrDefaultAsyncWithIncludes(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var include in includes)
                query = query.Include(include);

            if (orderBy != null)
                query = orderBy(query);

            return await query.FirstOrDefaultAsync(filter);
        }

        public virtual void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public virtual void AddRange(List<TEntity> list)
        {
            _dbSet.AddRange(list);
        }

        public virtual async Task AddAsync(TEntity obj)
        {
            await _dbSet.AddAsync(obj);
        }

        public virtual async Task AddRangeAsync(List<TEntity> list)
        {
            await _dbSet.AddRangeAsync(list);
        }

        private async Task<TEntity> FindAsync<TIdentity>(TIdentity id, params Include[] includes)
        {
            var model = await _dbSet.FindAsync(id);
            if (model != null)
            {
                if (includes != null)
                {
                    foreach (var includeTeble in includes)
                    {
                        LoadExplicitly(model, includeTeble);
                    }
                }
            }

            return model;
        }

        private void LoadExplicitly(object model, Include include)
        {
            if (model == null || include == null)
                return;

            switch (include.IncludeType)
            {
                case IncludeType.Collection:
                    _dbContext.Entry(model).Collection(include.IncludeName).Load();
                    break;

                case IncludeType.Reference:
                    _dbContext.Entry(model).Reference(include.IncludeName).Load();
                    break;
            }

            if (include.Includes != null)
            {
                var subModel = model.GetType().GetProperty(include.IncludeName).GetValue(model, null);
                if (subModel is System.Collections.IEnumerable)
                {
                    var counter = 0;
                    foreach (var item in subModel as System.Collections.IEnumerable)
                    {
                        if (counter == 1)
                            break;
                        subModel = item;
                        counter++;
                    }

                    if (counter == 0)
                        subModel = null;
                }

                foreach (var it in include.Includes)
                {
                    LoadExplicitly(subModel, it);
                }
            }
        }

        public virtual async Task<TEntity> GetAsync<TIdentity>(TIdentity id, params Include[] includes)
        {
            return await FindAsync(id, includes);
        }

        private const string AKTIF = "Aktif";

        public virtual async Task<IQueryable<TEntity>> All(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            bool aktifPropertyExist = _dbSet.GetType().GetGenericArguments().Any() &&
                                        _dbSet.GetType().GetGenericArguments().First().GetProperty(AKTIF) != null &&
                                        _dbSet.GetType().GetGenericArguments().First().GetProperty(AKTIF).PropertyType == typeof(bool);

            if (aktifPropertyExist)
                query = query.Where(q => EF.Property<bool>(q, AKTIF));

            foreach (var include in includes)
                query = query.Include(include);

            if (orderBy != null)
                query = orderBy(query);

            return await Task.Run(() => filter == null ? query.Select(k => k) : query.Where(filter));
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null, params string[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var include in includes)
                query = query.Include(include);

            if (filter != null)
                query = query.Where(filter);

            return await query.CountAsync();
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            _dbSet.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
        }
        public virtual async Task Update(TEntity obj)
        {
            _dbSet.Update(obj);
           
        }
        public virtual void UpdateRange(List<TEntity> list)
        {
            _dbSet.UpdateRange(list);
        }

        public virtual async Task DeleteAsync(TEntity obj)
        {
            EntityEntry dbEntityEntry = _dbContext.Entry(obj);

            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                _dbSet.Attach(obj);
                _dbSet.Remove(obj);
            }
        }

        public virtual async Task DeleteAsync(byte id)
        {
            var entity = await GetAsync(id);
            if (entity == null) return;
            await DeleteAsync(entity);
        }

        public virtual async Task DeleteAsync(short id)
        {
            var entity = await GetAsync(id);
            if (entity == null) return;
            await DeleteAsync(entity);
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            if (entity == null) return;
            await DeleteAsync(entity);
        }

        public virtual async Task DeleteAsync(long id)
        {
            var entity = await GetAsync(id);
            if (entity == null) return;
            await DeleteAsync(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<PagedResult<TEntity>> GetPagedAsync(BasePagedSortFilterSearchDAO basePagedSortFilterDAO)
        {
            IQueryable<TEntity> query = _dbSet;

            bool idPropertyExist = _dbSet.GetType().GetGenericArguments().Any() && _dbSet.GetType().GetGenericArguments().First().GetProperty("Id") != null;
            if (idPropertyExist)
            {
                var propType = _dbSet.GetType().GetGenericArguments().First().GetProperty("Id").PropertyType;
                if (propType == typeof(byte))
                    query = query.OrderByDescending(q => EF.Property<byte>(q, "Id"));
                else if (propType == typeof(int))
                    query = query.OrderByDescending(q => EF.Property<int>(q, "Id"));
                else if (propType == typeof(long))
                    query = query.OrderByDescending(q => EF.Property<long>(q, "Id"));
            }

            if (basePagedSortFilterDAO.Includes != null)
                foreach (var s in basePagedSortFilterDAO.Includes)
                    query = query.Include(s);

            if (basePagedSortFilterDAO.FilterItems != null && basePagedSortFilterDAO.FilterItems.Count > 0)
                query = query.Where(PageSortFilterHelper.GenerateFilterExpression<TEntity>(basePagedSortFilterDAO.FilterItems));

            if (basePagedSortFilterDAO.SortItems != null && basePagedSortFilterDAO.SortItems.Count > 0)
                query = PageSortFilterHelper.GenerateSortQuery(query, basePagedSortFilterDAO.SortItems);

            return await PagedResult<TEntity>.ToPagedListAsync(query, basePagedSortFilterDAO.PageNumber, basePagedSortFilterDAO.PageSize);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}