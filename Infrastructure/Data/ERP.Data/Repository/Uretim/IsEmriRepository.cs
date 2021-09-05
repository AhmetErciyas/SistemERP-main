using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class IsEmriRepository : BaseRepository<isEmri>, IIsEmriRepository
   {
       public IsEmriRepository(DataContext context)
       : base(context)
       {
       }
   }
}