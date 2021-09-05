using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class KimlikTurRepository : BaseRepository<kimlikTur>, IKimlikTurRepository
   {
       public KimlikTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}