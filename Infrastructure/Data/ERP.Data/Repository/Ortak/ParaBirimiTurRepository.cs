using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class ParaBirimiTurRepository : BaseRepository<paraBirimiTur>, IParaBirimiTurRepository
   {
       public ParaBirimiTurRepository(DataContext context)
       : base(context)
       {
       }
   }
}