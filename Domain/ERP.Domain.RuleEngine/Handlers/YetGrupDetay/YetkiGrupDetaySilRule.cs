using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.YetGrupDetay
{
    [Tag("YetkiGrupDetaySil")]
    public class YetkiGrupDetaySilRule : BaseCustomValidationRule<yetkiGruplariDetay, IYetkiGruplariDetayRepository>
    {
        protected override void Validate(IContext ctx, yetkiGruplariDetay model, IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository)
        {
            YetkiGrupDetayKontrol(ctx, model, yetkiGuruplariDetayRepository).Wait();

        }

        private async Task YetkiGrupDetayKontrol(IContext ctx, yetkiGruplariDetay model, IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository)
        {
            if (model.id == null || model.id == 0)
                ctx.Insert(new Exception("Grup seçmeniz zorunludur"));
            var grup = yetkiGuruplariDetayRepository.GetFirstOrDefaultAsync(q => q.id == model.id);
            if (grup == null)
                ctx.Insert(new Exception("Yetki  Sisteme Kayıtlı Değildir"));
        }
    }
}
