using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class SosyalGuvenlikKurumRepository : BaseRepository<sosyalGuvenlikKurum>, ISosyalGuvenlikKurumRepository
   {
       public SosyalGuvenlikKurumRepository(DataContext context)
       : base(context)
       {
       }
   }
}