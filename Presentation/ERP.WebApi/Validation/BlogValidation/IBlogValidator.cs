using ERP.Application.DTOs;

namespace ERP.WebApi.Validation
{
    public interface IBlogValidator
    {
        string[] ValidatePostId(long id);
        string[] ValidatePostAra(PostAraDTO postAraDTO);
        string[] ValidatePost(PostDTO postDTO);
    }
}
