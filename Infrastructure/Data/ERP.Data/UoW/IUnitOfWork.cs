using System;
using System.Threading.Tasks;

namespace ERP.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
