using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class AmbarRepository : BaseRepository<ambar>, IAmbarRepository
   {
       public AmbarRepository(DataContext context)
       : base(context)
       {
       }
   }
}