using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class EngellilikDurumRepository : BaseRepository<engellilikDurum>, IEngellilikDurumRepository
   {
       public EngellilikDurumRepository(DataContext context)
       : base(context)
       {
       }
   }
}