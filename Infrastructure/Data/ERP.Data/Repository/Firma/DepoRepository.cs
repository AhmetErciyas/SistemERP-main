using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class DepoRepository : BaseRepository<depo>, IDepoRepository
   {
       public DepoRepository(DataContext context)
       : base(context)
       {
       }
   }
}