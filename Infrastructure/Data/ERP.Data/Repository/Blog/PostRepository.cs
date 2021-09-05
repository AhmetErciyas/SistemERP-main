using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Blog;
using ERP.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(DataContext context)
            : base(context)
        {
        }

        public async Task<PagedResult<PostDAO>> PostAra(PostAraDAO postAraDAO)
        {
            var query = _dbSet
                .Include(q => q.Author)
                //.Include(q => q.Comments)
                //.Include(q => q.Tags)
                .Select(q => new PostDAO()
                {
                    PostId = q.Id,
                    AuthorId = q.AuthorId,
                    AuthorName = string.Format("{0} {1}", q.Author.Name, q.Author.Surname),
                    AuthorUsername = q.Author.Username,
                    PostDate = q.PostDate,
                    Title = q.Title,
                    Description = q.Description,
                   // Tags = q.Tags.Select(a => a.Name).ToList()
                })
                .AsQueryable();

            if (postAraDAO.AuthorId.HasValue)
                query = query.Where(q => q.AuthorId == postAraDAO.AuthorId.Value);

            if (!string.IsNullOrEmpty(postAraDAO.PostTitle))
                query = query.Where(q => q.Title.Contains(postAraDAO.PostTitle));

            return await PagedResult<PostDAO>.ToPagedListAsync(query, postAraDAO.PageNumber, postAraDAO.PageSize);
        }
    }
}
