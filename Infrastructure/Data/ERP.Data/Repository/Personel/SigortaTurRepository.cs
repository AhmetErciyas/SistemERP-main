using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class SigortaTurRepository : BaseRepository<sigortaTur>, ISigortaTurRepository
   {
       public SigortaTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}