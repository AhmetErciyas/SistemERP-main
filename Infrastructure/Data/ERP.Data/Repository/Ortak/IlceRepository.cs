using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class IlceRepository : BaseRepository<ilce>, IIlceRepository
   {
       public IlceRepository(DataContext context)
       : base(context)
       {
       }
   }
}