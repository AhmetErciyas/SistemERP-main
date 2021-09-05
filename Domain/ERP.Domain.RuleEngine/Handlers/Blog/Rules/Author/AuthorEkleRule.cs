using ERP.Data;
using ERP.Data.Entities;
using NRules.Fluent.Dsl;
using NRules.RuleModel;

namespace ERP.Domain.RuleEngine.Handlers.Blog.Rules
{
    [Tag("AuthorEkle")]
    public class AuthorEkleRule : BaseCustomValidationRule<Author, IAuthorRepository>
    {
        protected override void Validate(IContext ctx, Author model, IAuthorRepository repository)
        {

        }
    }
}
