using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class UnvanRepository : BaseRepository<unvan>, IUnvanRepository
    {
        public UnvanRepository(DataContext context)
        : base(context)
        {
        }

        public async Task<List<UnvanDAO>> UnvanAra(unvan unvan)
        {
            var query = _dbSet//.Include(f => f.Kisi).ThenInclude(q => q.Durum)
                              //.Include(f => f.Kisi).ThenInclude(q => q.Cinsiyet)
                             .Where(x =>
                               x.adi.StartsWith(unvan.adi) &&
                               (unvan.id != 0 ? x.id == unvan.id : true)

                             )
                                  .Select(f => new UnvanDAO()
                                  {
                                      id = f.id,
                                      adi = f.adi


                                  }).OrderBy(c => c.adi).AsQueryable();
            return await query.ToListAsync();
        }
    }
}