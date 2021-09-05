using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.YetkiGrup
{
    [Tag("YetkiGrupSil")]
    public class YetkiGrupSilRule : BaseCustomValidationRule<ERP.Data.Entities.yetkiGruplari, IYetkiGruplariRepository>
    {
        protected override void Validate(IContext ctx, yetkiGruplari model, IYetkiGruplariRepository yetkiGuruplariRepository)
        {
            YetkiGrupKontrol(ctx, model, yetkiGuruplariRepository).Wait();
        }

        private async Task YetkiGrupKontrol(IContext ctx, yetkiGruplari model, IYetkiGruplariRepository yetkiGuruplariRepository)
        {
            var grup = await yetkiGuruplariRepository.GetFirstOrDefaultAsync(q => q.id == model.id);
            if (grup == null)
                ctx.Insert(new Exception("Bu Kayıt Bulunmaktadır"));
        }
    }
}
