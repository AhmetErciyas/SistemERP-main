using System;
using System.Collections.Generic;

namespace ERP.Data.DAO.Blog
{
    public class PostDAO
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public long AuthorId { get; set; }
        public string AuthorUsername { get; set; }
        public string AuthorName { get; set; }
        public List<string> Tags { get; set; }
    }
}
