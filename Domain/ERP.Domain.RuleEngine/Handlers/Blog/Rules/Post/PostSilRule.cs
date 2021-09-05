using ERP.Data;
using ERP.Data.Entities;
using NRules.Fluent.Dsl;
using NRules.RuleModel;

namespace ERP.Domain.RuleEngine.Handlers.Blog.Rules
{
    [Tag("PostSil")]
    public class PostSilRule : BaseCustomValidationRule<Post, IPostRepository>
    {
        protected override void Validate(IContext ctx, Post model, IPostRepository repository)
        {

        }
    }
}
