namespace ERP.Application.DTOs
{
    public class PostAraDTO : BasePagedDTO
    {
        public long? PostId { get; set; }
        public string PostTitle { get; set; }
        public long? AuthorId { get; set; }
    }
}
