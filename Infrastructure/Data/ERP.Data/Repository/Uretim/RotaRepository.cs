using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class RotaRepository : BaseRepository<rota>, IRotaRepository
   {
       public RotaRepository(DataContext context)
       : base(context)
       {
       }
   }
}