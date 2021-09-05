using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class AsgariUcretRepository : BaseRepository<asgariUcret>, IAsgariUcretRepository
   {
       public AsgariUcretRepository(DataContext context)
       : base(context)
       {
       }
   }
}