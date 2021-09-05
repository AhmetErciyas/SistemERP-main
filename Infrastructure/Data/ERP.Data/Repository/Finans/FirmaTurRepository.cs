using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FirmaTurRepository : BaseRepository<firmaTur>, IFirmaTurRepository
   {
       public FirmaTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}