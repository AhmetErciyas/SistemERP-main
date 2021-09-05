using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OgrenimDurumRepository : BaseRepository<ogrenimDurum>, IOgrenimDurumRepository
   {
       public OgrenimDurumRepository(DataContext context)
       : base(context)
       {
       }
   }
}