using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class SozlesmeTurRepository : BaseRepository<sozlesmeTur>, ISozlesmeTurRepository
   {
       public SozlesmeTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}