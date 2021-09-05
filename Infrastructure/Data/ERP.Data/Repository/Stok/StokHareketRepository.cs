using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class StokHareketRepository : BaseRepository<stokHareket>, IStokHareketRepository
   {
       public StokHareketRepository(DataContext context)
       : base(context)
       {
       }
   }
}