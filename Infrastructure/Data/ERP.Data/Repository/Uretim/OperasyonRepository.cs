using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class OperasyonRepository : BaseRepository<operasyon>, IOperasyonRepository
   {
       public OperasyonRepository(DataContext context)
       : base(context)
       {
       }
   }
}