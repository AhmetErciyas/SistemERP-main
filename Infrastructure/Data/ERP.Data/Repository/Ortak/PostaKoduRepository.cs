using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
   public class PostaKoduRepository : BaseRepository<postaKodu>, IPostaKoduRepository
   {
       public PostaKoduRepository(DataContext context)
       : base(context)
       {
       }
   }
}