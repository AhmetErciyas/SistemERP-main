using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OrganizasyonSatirRepository : BaseRepository<organizasyonSatir>, IOrganizasyonSatirRepository
   {
       public OrganizasyonSatirRepository(DataContext context)
       : base(context)
       {
       }
   }
}