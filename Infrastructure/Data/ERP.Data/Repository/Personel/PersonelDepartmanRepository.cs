using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelDepartmanRepository : BaseRepository<personelDepartman>, IPersonelDepartmanRepository
   {
       public PersonelDepartmanRepository(DataContext context)
       : base(context)
       {
       }
   }
}