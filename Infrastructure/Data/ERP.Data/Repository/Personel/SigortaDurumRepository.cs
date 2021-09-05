using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class SigortaDurumRepository : BaseRepository<sigortaDurum>, ISigortaDurumRepository
   {
       public SigortaDurumRepository(DataContext context)
       : base(context)
       {
       }
   }
}