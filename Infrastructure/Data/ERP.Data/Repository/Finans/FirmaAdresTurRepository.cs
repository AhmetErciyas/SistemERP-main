using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FirmaAdresTurRepository : BaseRepository<firmaAdresTur>, IFirmaAdresTurRepository
   {
       public FirmaAdresTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}