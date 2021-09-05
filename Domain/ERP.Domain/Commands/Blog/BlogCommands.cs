using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Blog;
using ERP.Data.Entities;
using ERP.Domain.Core;
using System.Collections.Generic;

namespace ERP.Domain.Commands
{
    #region Post
    public class PostEkleCommand : BaseCommand<Post>
    {
        public Post Post { get; set; }
    }

    public class PostGuncelleCommand : BaseCommand<bool>
    {
        public Post Post { get; set; }
    }

    public class PostSilCommand : BaseCommand<bool>
    {
        public long PostId { get; set; }
    }

    #endregion

    #region Author
    public class AuthorEkleCommand : BaseCommand<Author>
    {
        public Author Author { get; set; }
    }

    public class AuthorGuncelleCommand : BaseCommand<bool>
    {
        public Author Author { get; set; }
    }

    public class AuthorSilCommand : BaseCommand<bool>
    {
        public long AuthorId { get; set; }
    }

    #endregion

    #region Comment
    public class CommentEkleCommand : BaseCommand<Comment>
    {
        public Comment Comment { get; set; }
    }

    public class CommentGuncelleCommand : BaseCommand<bool>
    {
        public Comment Comment { get; set; }
    }

    public class CommentSilCommand : BaseCommand<bool>
    {
        public long CommentId { get; set; }
    }

    #endregion

    public class PostQuery : BaseQuery<Post>
    {
        public long Id { get; set; }
    }

    public class PostAraQuery : BaseQuery<PagedResult<PostDAO>>
    {
        public PostAraDAO PostAraDAO { get; set; }
    }

    public class PostListeleQuery : BaseQuery<List<Post>>
    {

    }
}
