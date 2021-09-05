using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OdemePlanSatirRepository : BaseRepository<odemePlanSatir>, IOdemePlanSatirRepository
   {
       public OdemePlanSatirRepository(DataContext context)
       : base(context)
       {
       }
   }
}