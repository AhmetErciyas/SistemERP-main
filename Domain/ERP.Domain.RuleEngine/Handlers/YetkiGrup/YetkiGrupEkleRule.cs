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
    [Tag("YetkiGrupEkle")]
    public class YetkiGrupEkleRule : BaseCustomValidationRule<ERP.Data.Entities.yetkiGruplari, IYetkiGruplariRepository>
    {
        protected override void Validate(IContext ctx, yetkiGruplari model, IYetkiGruplariRepository yetkiGuruplariRepository)
        {
            NameKontrol(ctx, model, yetkiGuruplariRepository).Wait();
        }

        private async Task NameKontrol(IContext ctx, yetkiGruplari model, IYetkiGruplariRepository yetkiGuruplariRepository)
        {
            var grup = await yetkiGuruplariRepository.GetFirstOrDefaultAsync(q => q.adi == model.adi);
            if (grup != null)
                ctx.Insert(new Exception("Bu isimde Kayıt Bulunmaktadır"));
        }
    }
}
