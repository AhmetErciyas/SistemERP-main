using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class KaliteKontrolRepository : BaseRepository<kaliteKontrol>, IKaliteKontrolRepository
   {
       public KaliteKontrolRepository(DataContext context)
       : base(context)
       {
       }
   }
}