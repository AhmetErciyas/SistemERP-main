using ERP.Data.DAO.Base;

namespace ERP.Data.DAO.Blog
{
    public class PostAraDAO : BasePagedDAO
    {
        public long? PostId { get; set; }
        public string PostTitle { get; set; }
        public long? AuthorId { get; set; }
    }
}
