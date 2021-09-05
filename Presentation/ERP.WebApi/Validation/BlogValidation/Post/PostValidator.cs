using ERP.Application.DTOs;
using FluentValidation;

namespace ERP.WebApi.Validation
{
    public class PostValidator : BaseValidator<PostDTO>
    {
        public PostValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Title");
            RuleFor(x => x.PostDate).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Post Date");
            RuleFor(x => x.AuthorId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Author Id");
        }
    }
    public class PostAraValidator : BaseValidator<PostAraDTO>
    {
        public PostAraValidator()
        {
            RuleFor(x => x.PostTitle).NotEmpty().When(q => q.AuthorId == null || q.AuthorId == 0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Title");
            RuleFor(x => x.AuthorId).NotEmpty().When(q => string.IsNullOrEmpty(q.PostTitle)).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Author");
        }
    }

    public class PostIdValidator : BaseValidator<long>
    {
        public PostIdValidator()
        {
            RuleFor(x => x).NotEqual(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Post Id");
        }
    }
}
