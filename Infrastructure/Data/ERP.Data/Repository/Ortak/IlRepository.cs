using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class IlRepository : BaseRepository<il>, IIlRepository
   {
       public IlRepository(DataContext context)
       : base(context)
       {
       }
   }
}