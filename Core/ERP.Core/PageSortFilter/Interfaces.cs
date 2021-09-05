using System.Collections.Generic;

namespace ERP.Core.PageSortFilter
{
    public interface IPaged
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }

    public interface IFilter
    {
        List<IFilterItem> FilterItems { get; set; }
    }

    public interface ISort
    {
        List<ISortItem> SortItems { get; set; }
    }

    public interface ISearch
    {
        string SearchValue { get; set; }
    }

    public interface ISortItem
    {
        string SortProperty { get; set; }
        SortOrder Order { get; set; }
    }

    public interface IFilterItem
    {
        string FilterProperty { get; set; }
        FilterOperator Operator { get; set; }
        object Value { get; set; }
        object Value2 { get; set; }
    }

    public enum SortOrder
    {
        Asc,
        Desc
    }

    public enum FilterOperator
    {
        EqualTo = 1,
        Between = 2,
        GreaterThan = 3,
        LesserThan = 4,
        GreaterThanOrEqualTo = 5,
        LesserThanOrEqualTo = 6,
        NotEqualTo = 7,
        Contains = 8,
        StartsWith = 9,
        EndsWith = 10,
        ContainedIn = 11
    }
}
