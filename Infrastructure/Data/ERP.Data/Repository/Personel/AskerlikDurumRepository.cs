using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class AskerlikDurumRepository : BaseRepository<askerlikDurum>, IAskerlikDurumRepository
   {
       public AskerlikDurumRepository(DataContext context)
       : base(context)
       {
       }
   }
}