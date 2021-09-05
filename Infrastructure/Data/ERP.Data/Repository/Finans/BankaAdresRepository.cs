using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class BankaAdresRepository : BaseRepository<bankaAdres>, IBankaAdresRepository
   {
       public BankaAdresRepository(DataContext context)
       : base(context)
       {
       }
   }
}