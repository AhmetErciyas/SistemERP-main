using ERP.Application.DTOs;

namespace ERP.WebApi.Validation
{
    public class BlogValidator : IBlogValidator
    {
        public string[] ValidatePost(PostDTO postDTO)
        {
            return new PostValidator().ValidateModel(postDTO);
        }

        public string[] ValidatePostAra(PostAraDTO postAraDTO)
        {
            return new PostAraValidator().ValidateModel(postAraDTO);
        }

        public string[] ValidatePostId(long id)
        {
            return new PostIdValidator().ValidateModel(id);
        }
    }
}
