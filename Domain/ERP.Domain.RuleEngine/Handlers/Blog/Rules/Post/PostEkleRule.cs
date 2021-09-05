using ERP.Data;
using ERP.Data.Entities;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.Blog.Rules
{
    [Tag("PostEkle")]
    public class PostEkleRule : BaseCustomValidationRule<Post, IPostRepository, IAuthorRepository>
    {
        protected override void Validate(IContext ctx, Post model, IPostRepository repository1, IAuthorRepository repository2)
        {
            BaslikKontrol(ctx, model, repository1).Wait();
            TarihKontrol(ctx, model, repository1).Wait();
            YazarAktiflikKontrol(ctx, model, repository1, repository2).Wait();
        }

        private async Task BaslikKontrol(IContext ctx, Post model, IPostRepository repository)
        {
            if (string.IsNullOrEmpty(model.Title))
                ctx.Insert(new Exception("Post başlığı girmeniz zorunludur"));
            else if (model.Title.Length < 20)
                ctx.Insert(new Exception("Post başlığı minimum 20 karakter olmalıdır"));
        }

        private async Task TarihKontrol(IContext ctx, Post model, IPostRepository repository)
        {
            if (model.PostDate < DateTime.Now)
                ctx.Insert(new Exception("Post tarihi bugünün tarihinden eski olamaz"));
        }

        private async Task YazarAktiflikKontrol(IContext ctx, Post model, IPostRepository repository1, IAuthorRepository repository2)
        {
            if (model.AuthorId == 0)
                ctx.Insert(new Exception("Yazar girmeniz zorunludur"));

            var author = await repository2.GetFirstOrDefaultAsync(q => q.Id == model.AuthorId);
            if (author == null)
                ctx.Insert(new Exception("Yazar sistemde tanımlı değildir"));

            if (author.Status == false)
                ctx.Insert(new Exception("Yazar sistemde pasif gözükmektedir"));
        }
    }
}
