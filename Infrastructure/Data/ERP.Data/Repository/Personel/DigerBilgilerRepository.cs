using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class DigerBilgilerRepository : BaseRepository<digerBilgiler>, IDigerBilgilerRepository
   {
       public DigerBilgilerRepository(DataContext context)
       : base(context)
       {
       }
   }
}