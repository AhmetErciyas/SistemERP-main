using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Data.Repository
{
    public class IzinGrubuRepository : BaseRepository<izinGrubu>, IIzinGrubuRepository
    {
        public IzinGrubuRepository(DataContext context)
        : base(context)
        {
        }
    }
}
