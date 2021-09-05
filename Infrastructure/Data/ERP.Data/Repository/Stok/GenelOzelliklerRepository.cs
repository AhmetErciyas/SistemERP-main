using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class GenelOzelliklerRepository : BaseRepository<genelOzellikler>, IGenelOzelliklerRepository
   {
       public GenelOzelliklerRepository(DataContext context)
       : base(context)
       {
       }
   }
}