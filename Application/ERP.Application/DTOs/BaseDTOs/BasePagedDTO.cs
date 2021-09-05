using ERP.Core.PageSortFilter;
using System.Collections.Generic;

namespace ERP.Application.DTOs
{
    public class BasePagedDTO : IPaged
    {
        public bool GetAllData { get; set; }
        public int PageNumber { get; set; } = 0;
        public int PageSize { get; set; } = 20;
    }

    public class BaseSortDTO : ISort
    {
        public List<ISortItem> SortItems { get; set; }
    }

    public class BaseFilterDTO : IFilter
    {
        public List<IFilterItem> FilterItems { get; set; }
    }

    public class BasePagedSortDTO : BasePagedDTO, ISort
    {
        public List<ISortItem> SortItems { get; set; }
    }

    public class BasePagedFilterDTO : BasePagedDTO, IFilter
    {
        public List<IFilterItem> FilterItems { get; set; }
    }

    public class BasePagedSortFilterSearchDTO : BasePagedDTO, ISort, IFilter, ISearch
    {
        public List<ISortItem> SortItems { get; set; }
        public List<IFilterItem> FilterItems { get; set; }
        public string SearchValue { get; set; }
    }
}
