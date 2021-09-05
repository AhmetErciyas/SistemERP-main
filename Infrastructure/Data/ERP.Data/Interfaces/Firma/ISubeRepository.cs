using ERP.Core.PageSortFilter;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.Entities;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
    public interface ISubeRepository : IRepository<sube>
    {
        Task<PagedResult<FirmaSubeDAO>> FirmaSubeAra(FirmaSubeAraDAO personelAraDAO);
    }
}