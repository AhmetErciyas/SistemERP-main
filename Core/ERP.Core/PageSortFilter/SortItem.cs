namespace ERP.Core.PageSortFilter
{
    public class SortItem : ISortItem
    {
        public string SortProperty { get; set; }
        public SortOrder Order { get; set; }
    }
}
