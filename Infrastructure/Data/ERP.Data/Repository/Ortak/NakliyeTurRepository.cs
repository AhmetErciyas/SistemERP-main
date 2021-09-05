using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class NakliyeTurRepository : BaseRepository<nakliyeTur>, INakliyeTurRepository
   {
       public NakliyeTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}