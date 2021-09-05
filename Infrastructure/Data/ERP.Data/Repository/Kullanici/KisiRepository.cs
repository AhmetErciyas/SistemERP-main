using ERP.Data.Entities;

namespace ERP.Data.Repository
{
    public class KisiRepository : BaseRepository<Kisi>, ERP.Data.Interfaces.IKisiRepository
    {
        public KisiRepository(DataContext context)
        : base(context)
        {
        }
    }
}
