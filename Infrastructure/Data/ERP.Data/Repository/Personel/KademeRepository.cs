using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class KademeRepository : BaseRepository<kademe>, IKademeRepository
    {
        public KademeRepository(DataContext context)
        : base(context)
        {
        }

        public async Task<List<KademeDAO>> KademeAra(kademe kademe)
        {
            var query = _dbSet//.Include(f => f.Kisi).ThenInclude(q => q.Durum)
                              //.Include(f => f.Kisi).ThenInclude(q => q.Cinsiyet)
                              .Where(x =>
                                x.adi.StartsWith(kademe.adi) &&
                                (kademe.id != 0 ? x.id == kademe.id : true)
                              )
                                   .Select(f => new KademeDAO()
                                   {
                                       id = f.id,
                                       adi = f.adi,


                                   }).OrderBy(c => c.adi).AsQueryable();
            return await query.ToListAsync();
        }
    }
}