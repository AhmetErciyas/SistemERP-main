using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FirmaAdresRepository : BaseRepository<firmaAdres>, IFirmaAdresRepository
   {
       public FirmaAdresRepository(DataContext context)
       : base(context)
       {
       }
   }
}