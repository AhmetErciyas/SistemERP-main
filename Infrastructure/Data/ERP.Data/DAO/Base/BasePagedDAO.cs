using ERP.Core.PageSortFilter;
using System.Collections.Generic;

namespace ERP.Data.DAO.Base
{
    public class BasePagedDAO : IPaged
    {
        public bool GetAllData { get; set; }
        public int PageNumber { get; set; } = 0;
        public int PageSize { get; set; } = 10;
        public string[] Includes { get; set; }
    }

    public class BasePagedSortFilterSearchDAO : BasePagedDAO, ISort, IFilter, ISearch
    {
        public List<ISortItem> SortItems { get; set; } = new List<ISortItem>();
        public List<IFilterItem> FilterItems { get; set; } = new List<IFilterItem>();
        public string SearchValue { get; set; }
    }
}
