using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class UlkeRepository : BaseRepository<ulke>, IUlkeRepository
   {
       public UlkeRepository(DataContext context)
       : base(context)
       {
       }
   }
}