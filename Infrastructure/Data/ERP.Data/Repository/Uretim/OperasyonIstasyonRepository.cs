using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OperasyonIstasyonRepository : BaseRepository<operasyonIstasyon>, IOperasyonIstasyonRepository
   {
       public OperasyonIstasyonRepository(DataContext context)
       : base(context)
       {
       }
   }
}