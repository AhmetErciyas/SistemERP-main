using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PaketlemeKodRepository : BaseRepository<paketlemeKod>, IPaketlemeKodRepository
   {
       public PaketlemeKodRepository(DataContext context)
       : base(context)
       {
       }
   }
}