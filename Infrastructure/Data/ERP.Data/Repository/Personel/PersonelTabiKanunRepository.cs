using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelTabiKanunRepository : BaseRepository<personelTabiKanun>, IPersonelTabiKanunRepository
   {
       public PersonelTabiKanunRepository(DataContext context)
       : base(context)
       {
       }
   }
}