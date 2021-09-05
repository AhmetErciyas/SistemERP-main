using ERP.Core.PageSortFilter;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class SubeRepository : BaseRepository<sube>, ISubeRepository
    {
        public SubeRepository(DataContext context)
        : base(context)
        {
        }

        public async Task<PagedResult<FirmaSubeDAO>> FirmaSubeAra(FirmaSubeAraDAO model)
        {
            var query = _dbSet//.Include(f => f.Kisi).ThenInclude(q => q.Durum)
                              //.Include(f => f.Kisi).ThenInclude(q => q.Cinsiyet)
                              .Where(x =>
                                x.adi.StartsWith(model.Adi) &&
                                (model.FirmaId != 0 ? x.firmaid == model.FirmaId : true)
                              )
                                   .Select(f => new FirmaSubeDAO()
                                   {
                                       Id = f.id,
                                       Adi = f.adi,
                                       FirmaId = f.firmaid,
                                       FirmaAdi = f.firma.adi

                                   }).OrderBy(c => c.Adi).AsQueryable();

            //if (model.FirmaId.HasValue)
            //    query = query.Where(f => f.Id == model.FirmaId.Value);



            //if (!string.IsNullOrWhiteSpace(model.Adi))
            //    query = query.Where(c => c.Adi == model.Adi);



            return await PagedResult<FirmaSubeDAO>.ToPagedListAsync(query, model.PageNumber, model.PageSize);
        }
    }
}