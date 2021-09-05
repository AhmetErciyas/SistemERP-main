using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class StokHareketTurRepository : BaseRepository<stokHareketTur>, IStokHareketTurRepository
   {
       public StokHareketTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}