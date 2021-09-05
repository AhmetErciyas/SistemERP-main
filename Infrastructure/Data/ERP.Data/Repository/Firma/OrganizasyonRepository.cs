using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OrganizasyonRepository : BaseRepository<organizasyon>, IOrganizasyonRepository
   {
       public OrganizasyonRepository(DataContext context)
       : base(context)
       {
       }
   }
}