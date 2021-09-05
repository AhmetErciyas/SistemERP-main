using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class VergiDaireRepository : BaseRepository<vergiDaire>, IVergiDaireRepository
   {
       public VergiDaireRepository(DataContext context)
       : base(context)
       {
       }
   }
}