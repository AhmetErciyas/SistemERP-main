using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FiyatListeTurRepository : BaseRepository<fiyatListeTur>, IFiyatListeTurRepository
   {
       public FiyatListeTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}