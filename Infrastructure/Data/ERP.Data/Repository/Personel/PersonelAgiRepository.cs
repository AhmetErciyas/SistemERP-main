using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelAgiRepository : BaseRepository<personelAgi>, IPersonelAgiRepository
   {
       public PersonelAgiRepository(DataContext context)
       : base(context)
       {
       }
   }
}