using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class MalzemeRepository : BaseRepository<malzeme>, IMalzemeRepository
   {
       public MalzemeRepository(DataContext context)
       : base(context)
       {
       }
   }
}