using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class YetkilerRepository : BaseRepository<yetkiler>, IYetkilerRepository
   {
       public YetkilerRepository(DataContext context)
       : base(context)
       {
       }
   }
}