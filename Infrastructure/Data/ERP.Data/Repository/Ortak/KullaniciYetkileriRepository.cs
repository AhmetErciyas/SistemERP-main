using ERP.Data.DAO.KullaniciYetkileri;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class KullaniciYetkileriRepository : BaseRepository<kullaniciYetkileri>, IKullaniciYetkileriRepository
    {
        public KullaniciYetkileriRepository(DataContext context)
        : base(context)
        {
        }

        public async Task<List<KullaniciYetkiDAO>> KullanicalarıGetir()
        {
            var query = _dbSet//.Include(f => f.Kisi).ThenInclude(q => q.Durum)
                              //.Include(f => f.Kisi).ThenInclude(q => q.Cinsiyet)

                                    .Select(f => new KullaniciYetkiDAO()
                                    {
                                        id = f.id,
                                        kulaniciAdi = f.kullanici.personel.adi,
                                        yetkiAdi = f.yetki.adi,
                                        kullaniciId = f.kullanici.id,
                                        yetkiId = f.yetki.id
                                    }).OrderBy(c => c.id).AsQueryable();
            return await query.ToListAsync();
        }
    }
}