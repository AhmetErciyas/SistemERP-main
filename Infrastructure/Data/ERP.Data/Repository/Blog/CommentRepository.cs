using ERP.Data.Entities;

namespace ERP.Data
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DataContext context)
            : base(context)
        {
        }
    }
}
