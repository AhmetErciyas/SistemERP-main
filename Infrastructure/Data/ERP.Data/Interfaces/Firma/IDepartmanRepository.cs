using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
    public interface IDepartmanRepository : IRepository<departman>
    {
        Task<List<DepartmanDAO>> DepartmanAra(departman departman);

    }
}
