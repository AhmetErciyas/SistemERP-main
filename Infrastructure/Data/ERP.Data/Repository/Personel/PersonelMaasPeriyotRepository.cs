using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PersonelMaasPeriyotRepository : BaseRepository<personelMaasPeriyot>, IPersonelMaasPeriyotRepository
   {
       public PersonelMaasPeriyotRepository(DataContext context)
       : base(context)
       {
       }
   }
}