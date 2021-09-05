using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class MalzemeOzellikleriRepository : BaseRepository<malzemeOzellikleri>, IMalzemeOzellikleriRepository
   {
       public MalzemeOzellikleriRepository(DataContext context)
       : base(context)
       {
       }
   }
}