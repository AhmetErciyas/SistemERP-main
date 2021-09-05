using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelEmeklilikRepository : BaseRepository<personelEmeklilik>, IPersonelEmeklilikRepository
   {
       public PersonelEmeklilikRepository(DataContext context)
       : base(context)
       {
       }
   }
}