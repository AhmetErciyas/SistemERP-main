using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FirmaRepository : BaseRepository<firma>, IFirmaRepository
   {
       public FirmaRepository(DataContext context)
       : base(context)
       {
       }
   }
}