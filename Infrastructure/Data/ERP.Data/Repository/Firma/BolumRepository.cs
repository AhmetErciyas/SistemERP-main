using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class BolumRepository : BaseRepository<bolum>, IBolumRepository
   {
       public BolumRepository(DataContext context)
       : base(context)
       {
       }
   }
}