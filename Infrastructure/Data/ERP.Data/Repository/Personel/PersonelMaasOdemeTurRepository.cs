using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelMaasOdemeTurRepository : BaseRepository<personelMaasOdemeTur>, IPersonelMaasOdemeTurRepository
   {
       public PersonelMaasOdemeTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}