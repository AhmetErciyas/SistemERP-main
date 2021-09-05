using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelKimlikRepository : BaseRepository<personelKimlik>, IPersonelKimlikRepository
   {
       public PersonelKimlikRepository(DataContext context)
       : base(context)
       {
       }
   }
}