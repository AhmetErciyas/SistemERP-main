using ERP.Data.DAO.Kullanici;
using ERP.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
    public interface IKullaniciRepository : IRepository<kullanici>
    {
        Task<KullaniciDAO> GetKullanici(long kullaniciId);
        List<yetkiler> GetKullaniciYetkileri(kullanici kullanici);

    }
}
