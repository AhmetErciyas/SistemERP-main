using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class BankaHesapRepository : BaseRepository<bankaHesap>, IBankaHesapRepository
   {
       public BankaHesapRepository(DataContext context)
       : base(context)
       {
       }
   }
}