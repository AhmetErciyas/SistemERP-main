using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class GrupRepository : BaseRepository<grup>, IGrupRepository
   {
       public GrupRepository(DataContext context)
       : base(context)
       {
       }
   }
}