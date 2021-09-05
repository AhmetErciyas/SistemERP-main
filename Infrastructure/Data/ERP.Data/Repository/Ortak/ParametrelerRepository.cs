using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class ParametrelerRepository : BaseRepository<parametreler>, IParametrelerRepository
   {
       public ParametrelerRepository(DataContext context)
       : base(context)
       {
       }
   }
}