using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class ParaBirimRepository : BaseRepository<paraBirim>, IParaBirimRepository
   {
       public ParaBirimRepository(DataContext context)
       : base(context)
       {
       }
   }
}