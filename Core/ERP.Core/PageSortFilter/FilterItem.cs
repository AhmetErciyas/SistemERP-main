namespace ERP.Core.PageSortFilter
{
    public class FilterItem : IFilterItem
    {
        private string filterProperty;
        public string FilterProperty
        {
            get
            {
                return filterProperty;
            }
            set
            {
                filterProperty = value.Trim();
            }
        }

        public FilterOperator Operator { get; set; }
        public object Value { get; set; }
        public object Value2 { get; set; }
    }
}
