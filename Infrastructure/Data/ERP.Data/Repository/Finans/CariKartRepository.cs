using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class CariKartRepository : BaseRepository<cariKart>, ICariKartRepository
   {
       public CariKartRepository(DataContext context)
       : base(context)
       {
       }
   }
}