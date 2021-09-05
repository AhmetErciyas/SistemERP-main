using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class SiparisTurRepository : BaseRepository<siparisTur>, ISiparisTurRepository
   {
       public SiparisTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}