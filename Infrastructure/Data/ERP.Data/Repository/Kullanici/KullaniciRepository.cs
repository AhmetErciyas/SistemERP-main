using ERP.Data.DAO.Kullanici;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class KullaniciRepository : BaseRepository<kullanici>, IKullaniciRepository
    {
        public KullaniciRepository(DataContext context)
        : base(context)
        {
        }

        public async Task<KullaniciDAO> GetKullanici(long kullaniciId)
        {
            var queryBase = GetKullaniciBaseQuery();
            queryBase = queryBase.Where(kfr => kfr.id == kullaniciId);

            return await queryBase.Select(kullaniciEntity => new KullaniciDAO()
            {
                Id = kullaniciEntity.id,
                Ad = kullaniciEntity.personel.adi,
                Soyad = kullaniciEntity.personel.soyadi,
                //TCKimlikNo = kullaniciEntity.Personel.Kisi.TCKN,
                //Email = kullaniciEntity.Personel.Kisi.Mail,
                //SehirId = kullaniciEntity.Personel.Kisi.KisiIletisim.FirstOrDefault().IlceId,
            }).FirstOrDefaultAsync();
        }

        private IQueryable<kullanici> GetKullaniciBaseQuery()
        {
            return _dbContext.kullanici.Include(q => q.personel).ThenInclude(q => q.personelKimlik)//.Kullanici.Include(x => x.Personel).ThenInclude(q => q.Kisi).ThenInclude(q => q.KisiIletisim)
                                                                                                   // .Include(q => q.Personel).ThenInclude(q => q.PersonelDepartman).ThenInclude(q => q.Departman);
               ;
        }

        public List<yetkiler> GetKullaniciYetkileri(kullanici kullanici)
        {
            using (var context = new DataContext())
            {
                var result = from yetkiler in context.yetkiler
                             join kullaniciYetkileri in context.kullaniciYetkileri
                                 on yetkiler.id equals kullaniciYetkileri.yetkiId
                             where kullaniciYetkileri.kullaniciId == kullanici.id
                             select new yetkiler { id = yetkiler.id, adi = yetkiler.adi };
                return result.ToList();

            }
        }
    }
}