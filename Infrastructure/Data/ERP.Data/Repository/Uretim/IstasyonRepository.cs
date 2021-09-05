using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class IstasyonRepository : BaseRepository<istasyon>, IIstasyonRepository
   {
       public IstasyonRepository(DataContext context)
       : base(context)
       {
       }
   }
}