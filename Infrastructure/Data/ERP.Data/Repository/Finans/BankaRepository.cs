using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class BankaRepository : BaseRepository<banka>, IBankaRepository
   {
       public BankaRepository(DataContext context)
       : base(context)
       {
       }
   }
}