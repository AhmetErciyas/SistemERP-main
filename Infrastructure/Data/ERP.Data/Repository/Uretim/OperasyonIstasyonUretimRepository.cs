using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OperasyonIstasyonUretimRepository : BaseRepository<operasyonIstasyonUretim>, IOperasyonIstasyonUretimRepository
   {
       public OperasyonIstasyonUretimRepository(DataContext context)
       : base(context)
       {
       }
   }
}