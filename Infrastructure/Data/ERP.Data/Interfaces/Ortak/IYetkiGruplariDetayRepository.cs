using ERP.Data.DAO.YetkiGruplariDetay;
using ERP.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
   public interface IYetkiGruplariDetayRepository : IRepository<yetkiGruplariDetay>
   {
        Task<List<YetkiGruplariDetayDAO>> YetkiGruplariGetir();
    }
}