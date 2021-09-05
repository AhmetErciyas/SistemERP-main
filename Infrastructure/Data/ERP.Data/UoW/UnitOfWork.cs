using ERP.Data.Entities;
using System.Threading.Tasks;

namespace ERP.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
