using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelMaasRepository : BaseRepository<personelMaas>, IPersonelMaasRepository
   {
       public PersonelMaasRepository(DataContext context)
       : base(context)
       {
       }
   }
}