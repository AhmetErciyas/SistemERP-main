using ERP.Data;
using ERP.Data.Entities;
using NRules.Fluent.Dsl;
using NRules.RuleModel;

namespace ERP.Domain.RuleEngine.Handlers.Blog.Rules
{
    [Tag("CommentGuncelle")]
    public class CommentGuncelleRule : BaseCustomValidationRule<Comment, ICommentRepository>
    {
        protected override void Validate(IContext ctx, Comment model, ICommentRepository repository)
        {

        }
    }
}
