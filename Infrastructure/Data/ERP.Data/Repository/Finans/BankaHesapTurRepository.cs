using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class BankaHesapTurRepository : BaseRepository<bankaHesapTur>, IBankaHesapTurRepository
   {
       public BankaHesapTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}