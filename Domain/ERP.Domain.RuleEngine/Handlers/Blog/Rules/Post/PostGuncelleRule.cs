using ERP.Data;
using ERP.Data.Entities;
using NRules.Fluent.Dsl;
using NRules.RuleModel;

namespace ERP.Domain.RuleEngine.Handlers.Blog.Rules
{
    [Tag("PostGuncelle")]
    public class PostGuncelleRule : BaseCustomValidationRule<Post, IPostRepository>
    {
        protected override void Validate(IContext ctx, Post model, IPostRepository repository)
        {

        }
    }
}
