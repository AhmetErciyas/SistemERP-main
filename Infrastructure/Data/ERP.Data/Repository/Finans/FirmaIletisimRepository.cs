using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FirmaIletisimRepository : BaseRepository<firmaIletisim>, IFirmaIletisimRepository
   {
       public FirmaIletisimRepository(DataContext context)
       : base(context)
       {
       }
   }
}