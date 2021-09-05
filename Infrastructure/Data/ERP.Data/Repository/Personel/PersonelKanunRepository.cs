using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelKanunRepository : BaseRepository<personelKanun>, IPersonelKanunRepository
   {
       public PersonelKanunRepository(DataContext context)
       : base(context)
       {
       }
   }
}