using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class IstasyonUretimRepository : BaseRepository<istasyonUretim>, IIstasyonUretimRepository
   {
       public IstasyonUretimRepository(DataContext context)
       : base(context)
       {
       }
   }
}