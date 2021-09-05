using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Blog;
using ERP.Data.Entities;
using System.Threading.Tasks;

namespace ERP.Data
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<PagedResult<PostDAO>> PostAra(PostAraDAO postAraDAO);
    }
}