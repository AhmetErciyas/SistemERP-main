using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Domain.RuleEngine.Handlers.Blog
{
    public interface IBlogRuleHandler
    {
        IRuleValidationResult ValidatePostEkle(IPostRepository postRepository, IAuthorRepository authorRepository, Post post);

        IRuleValidationResult ValidatePostGuncelle(IPostRepository postRepository, Post post);

        IRuleValidationResult ValidatePostSil(IPostRepository postRepository, Post post);

        IRuleValidationResult ValidateAuthorEkle(IAuthorRepository AuthorRepository, Author Author);

        IRuleValidationResult ValidateAuthorGuncelle(IAuthorRepository AuthorRepository, Author Author);

        IRuleValidationResult ValidateAuthorSil(IAuthorRepository AuthorRepository, Author Author);

        IRuleValidationResult ValidateCommentEkle(ICommentRepository CommentRepository, Comment Comment);

        IRuleValidationResult ValidateCommentGuncelle(ICommentRepository CommentRepository, Comment Comment);

        IRuleValidationResult ValidateCommentSil(ICommentRepository CommentRepository, Comment Comment);
    }
}
