using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class StokTurRepository : BaseRepository<stokTur>, IStokTurRepository
   {
       public StokTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}