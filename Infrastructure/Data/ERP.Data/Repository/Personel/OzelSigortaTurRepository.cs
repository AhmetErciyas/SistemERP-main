using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OzelSigortaTurRepository : BaseRepository<ozelSigortaTur>, IOzelSigortaTurRepository
   {
       public OzelSigortaTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}