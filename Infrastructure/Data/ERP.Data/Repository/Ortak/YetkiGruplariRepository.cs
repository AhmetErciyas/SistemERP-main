using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class YetkiGruplariRepository : BaseRepository<yetkiGruplari>, IYetkiGruplariRepository
   {
       public YetkiGruplariRepository(DataContext context)
       : base(context)
       {
       }
   }
}