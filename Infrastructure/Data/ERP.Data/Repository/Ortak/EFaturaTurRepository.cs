using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class EFaturaTurRepository : BaseRepository<eFaturaTur>, IEFaturaTurRepository
   {
       public EFaturaTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}