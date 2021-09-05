using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class ReceteRepository : BaseRepository<recete>, IReceteRepository
   {
       public ReceteRepository(DataContext context)
       : base(context)
       {
       }
   }
}