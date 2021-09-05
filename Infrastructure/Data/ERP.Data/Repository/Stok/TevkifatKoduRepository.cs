using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class TevkifatKoduRepository : BaseRepository<tevkifatKodu>, ITevkifatKoduRepository
   {
       public TevkifatKoduRepository(DataContext context)
       : base(context)
       {
       }
   }
}