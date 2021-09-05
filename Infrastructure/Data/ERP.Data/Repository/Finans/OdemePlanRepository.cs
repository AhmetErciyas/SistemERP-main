using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OdemePlanRepository : BaseRepository<odemePlan>, IOdemePlanRepository
   {
       public OdemePlanRepository(DataContext context)
       : base(context)
       {
       }
   }
}