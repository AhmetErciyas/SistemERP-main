using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class EkGelirGiderTurRepository : BaseRepository<ekGelirGiderTur>, IEkGelirGiderTurRepository
   {
       public EkGelirGiderTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}