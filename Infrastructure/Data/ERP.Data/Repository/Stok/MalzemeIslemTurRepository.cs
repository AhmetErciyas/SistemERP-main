using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class MalzemeIslemTurRepository : BaseRepository<malzemeIslemTur>, IMalzemeIslemTurRepository
   {
       public MalzemeIslemTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}