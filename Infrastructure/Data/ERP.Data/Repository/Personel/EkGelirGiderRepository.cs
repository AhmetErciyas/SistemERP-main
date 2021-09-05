using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class EkGelirGiderRepository : BaseRepository<ekGelirGider>, IEkGelirGiderRepository
   {
       public EkGelirGiderRepository(DataContext context)
       : base(context)
       {
       }
   }
}