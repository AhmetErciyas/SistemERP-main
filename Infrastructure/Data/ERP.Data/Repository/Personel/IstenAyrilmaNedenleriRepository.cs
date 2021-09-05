using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class IstenAyrilmaNedenleriRepository : BaseRepository<istenAyrilmaNedenleri>, IIstenAyrilmaNedenleriRepository
   {
       public IstenAyrilmaNedenleriRepository(DataContext context)
       : base(context)
       {
       }
   }
}