using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class EkGelirGiderAciklamaRepository : BaseRepository<ekGelirGiderAciklama>, IEkGelirGiderAciklamaRepository
   {
       public EkGelirGiderAciklamaRepository(DataContext context)
       : base(context)
       {
       }
   }
}