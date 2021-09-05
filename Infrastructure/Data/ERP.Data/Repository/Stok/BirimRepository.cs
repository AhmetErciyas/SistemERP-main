using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class BirimRepository : BaseRepository<birim>, IBirimRepository
   {
       public BirimRepository(DataContext context)
       : base(context)
       {
       }
   }
}