using ERP.Data.DAO.KullaniciYetkileri;
using ERP.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
   public interface IKullaniciYetkileriRepository : IRepository<kullaniciYetkileri>
    {
        Task<List<KullaniciYetkiDAO>> KullanicalarıGetir();
    }
}