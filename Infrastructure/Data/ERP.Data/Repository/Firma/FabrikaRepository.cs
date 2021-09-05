using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FabrikaRepository : BaseRepository<fabrika>, IFabrikaRepository
   {
       public FabrikaRepository(DataContext context)
       : base(context)
       {
       }
   }
}