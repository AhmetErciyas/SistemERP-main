using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FirmaIletisimTurRepository : BaseRepository<firmaIletisimTur>, IFirmaIletisimTurRepository
   {
       public FirmaIletisimTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}