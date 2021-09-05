using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
    public interface IKademeRepository : IRepository<kademe>
    {
        Task<List<KademeDAO>> KademeAra(kademe kademe);

    }
}
