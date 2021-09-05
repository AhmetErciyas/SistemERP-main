using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class FirmaYonRepository : BaseRepository<firmaYon>, IFirmaYonRepository
   {
       public FirmaYonRepository(DataContext context)
       : base(context)
       {
       }
   }
}