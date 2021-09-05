using ERP.Data.Entities;

namespace ERP.Data
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DataContext context)
            : base(context)
        {
        }
    }
}
