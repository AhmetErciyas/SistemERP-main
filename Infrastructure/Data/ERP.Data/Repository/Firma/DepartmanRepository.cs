using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class DepartmanRepository : BaseRepository<departman>, IDepartmanRepository
    {
        public DepartmanRepository(DataContext context)
            : base(context)
        {
        }

        public async Task<List<DepartmanDAO>> DepartmanAra(departman departman)
        {
            var query =  _dbSet//.Include(f => f.Kisi).ThenInclude(q => q.Durum)
                              //.Include(f => f.Kisi).ThenInclude(q => q.Cinsiyet)
                              .Where(x =>
                                x.adi.StartsWith(departman.adi) &&
                                (departman.bolumid != 0 ? x.bolumid == departman.bolumid : true) &&
                                (departman.id != 0 ? x.id == departman.id : true)
                              )
                                   .Select(f => new DepartmanDAO()
                                   {
                                       id = f.id,
                                       adi = f.adi,
                                       bolumid = f.bolumid,
                                       No= f.No,

                                   }).OrderBy(c => c.adi).AsQueryable();
            return await  query.ToListAsync();

        }
    }
}
