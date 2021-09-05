using ERP.Data.DAO.YetkiGruplariDetay;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class YetkiGruplariDetayRepository : BaseRepository<yetkiGruplariDetay>, IYetkiGruplariDetayRepository
    {
        public YetkiGruplariDetayRepository(DataContext context)
        : base(context)
        {
        }

        public async Task<List<YetkiGruplariDetayDAO>> YetkiGruplariGetir()
        {
            var query = _dbSet//.Include(f => f.Kisi).ThenInclude(q => q.Durum)
                              //.Include(f => f.Kisi).ThenInclude(q => q.Cinsiyet)

                                    .Select(f => new YetkiGruplariDetayDAO()
                                    {
                                        id = f.id,
                                        YetkiAdi = f.yetki.adi,
                                        GrupAdi = f.grup.adi,
                                        YetkiId = f.yetkiId,
                                        GrupId = f.grupId

                                    }).OrderBy(c => c.id).AsQueryable();
            return await query.ToListAsync();
        }
    }
}