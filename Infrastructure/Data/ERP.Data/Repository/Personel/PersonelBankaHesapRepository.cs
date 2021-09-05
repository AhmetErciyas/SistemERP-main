using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelBankaHesapRepository : BaseRepository<personelBankaHesap>, IPersonelBankaHesapRepository
   {
       public PersonelBankaHesapRepository(DataContext context)
       : base(context)
       {
       }
   }
}