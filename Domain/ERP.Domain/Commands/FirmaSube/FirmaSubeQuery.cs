using ERP.Core.PageSortFilter;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.DAO.Personel;
using ERP.Domain.Core;

namespace ERP.Domain.Commands.Personel
{
    public class FirmaSubeAraQuery : BaseQuery<PagedResult<FirmaSubeDAO>>
    {
        public FirmaSubeAraDAO FirmaSube { get; set; }
    }

    public class FirmaSubeQuery : BaseQuery<ERP.Data.Entities.sube>
    {
        public int firmaSubeId { get; set; }
    }
}
