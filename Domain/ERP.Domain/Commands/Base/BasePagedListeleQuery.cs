using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Base;
using ERP.Domain.Core;

namespace ERP.Domain.Commands.Base
{
    public class BasePagedListeleQuery<TEntity> : BaseQuery<PagedResult<TEntity>>
    {
        public BasePagedSortFilterSearchDAO PagedSortFilterSearchDAO { get; set; }

        public BasePagedListeleQuery()
        {
        }

        public BasePagedListeleQuery(BasePagedSortFilterSearchDAO basePagedSortFilterDAO)
        {
            PagedSortFilterSearchDAO = basePagedSortFilterDAO;
        }
    }
}