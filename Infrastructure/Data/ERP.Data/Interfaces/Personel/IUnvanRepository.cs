using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
    public interface IUnvanRepository : IRepository<unvan>
    {
        Task<List<UnvanDAO>> UnvanAra(unvan unvan);

    }
}
