using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.IstenAyrılmaNeden
{
    [Tag("IstenAyrılmaNedenSil")]
    public class IstenAyrılmaNedenSilRule : BaseCustomValidationRule<ERP.Data.Entities.istenAyrilmaNedenleri, IIstenAyrilmaNedenleriRepository>
    {
        protected override void Validate(IContext ctx, istenAyrilmaNedenleri model, IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository)
        {
            IstenAyrılmaNedenKontrol(ctx, model, ıstenAyrilmaNedenleriRepository).Wait();
        }

        private async Task IstenAyrılmaNedenKontrol(IContext ctx, istenAyrilmaNedenleri model, IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository)
        {
            var grup = await ıstenAyrilmaNedenleriRepository.GetFirstOrDefaultAsync(q => q.id == model.id);
            if (grup == null)
                ctx.Insert(new Exception("Bu Kayıt Bulunmaktadır"));
        }
    }
}
