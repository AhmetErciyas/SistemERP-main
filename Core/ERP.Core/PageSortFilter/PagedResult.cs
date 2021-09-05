using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Core.PageSortFilter
{
    public class PagedResultSP<T> where T : new()
    {
        public async static Task<PagedResult<T>> ToPagedListForSP(SqlPagedDAO<T> source, int pageNumber, int pageSize)
        {
            var sayfalama = source.SpPaging.FirstOrDefault();
            return new PagedResult<T>(source.SpDataResult, sayfalama.TotalCount, pageNumber, pageSize);
        }
    }

    public class PagingInfo
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        public PagingInfo()
        {
        }
    }

    public class PagedResult<T> : PagingInfo
    {
        public List<T> ResultSet { get; set; }

        public PagedResult(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            ResultSet = items;
        }

        /// <summary>
        /// sql query den sayfalı türde veri çeker
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public async static Task<PagedResult<T>> ToPagedListAsync(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();

            if (pageNumber < 0)
                pageNumber = 0;
            var items = await source.Skip((pageNumber) * pageSize).Take(pageSize).ToListAsync();

            return new PagedResult<T>(items, count, pageNumber, pageSize);
        }

        public static PagedResult<T> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();

            if (pageNumber < 0)
                pageNumber = 0;
            var items = source.Skip((pageNumber) * pageSize).Take(pageSize).ToList();

            return new PagedResult<T>(items, count, pageNumber, pageSize);
        }

        public static PagedResult<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();

            if (pageNumber < 0)
                pageNumber = 0;
            var items = source.Skip((pageNumber) * pageSize).Take(pageSize).ToList();

            return new PagedResult<T>(items, count, pageNumber, pageSize);
        }

        public async static Task<PagedResult<TTarget>> ToMappedPagedList<TTarget>(IQueryable<T> source, Func<T, TTarget> map, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();

            if (pageNumber < 0)
                pageNumber = 0;
            var items = await source.Skip((pageNumber) * pageSize).Take(pageSize).ToListAsync();
            return new PagedResult<TTarget>(items.Select(i => map(i)).ToList(), count, pageNumber, pageSize);
        }
    }
}
