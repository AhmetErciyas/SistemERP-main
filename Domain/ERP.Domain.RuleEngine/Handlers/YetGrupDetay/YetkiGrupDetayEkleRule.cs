using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.YetGrupDetay
{
    [Tag("YetkiGrupDetayEkle")]
    public class YetkiGrupDetayEkleRule : BaseCustomValidationRule<ERP.Data.Entities.yetkiGruplariDetay, IYetkiGruplariDetayRepository,IYetkilerRepository,IGrupRepository>
    {
        protected override void Validate(IContext ctx, Data.Entities.yetkiGruplariDetay model, IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, IYetkilerRepository yetkilerRepository, IGrupRepository grupRepository)
        {
            YetkiKontrol(ctx, model, yetkilerRepository).Wait();
            GrupKontrol(ctx, model, grupRepository).Wait();
        }

        private async Task GrupKontrol(IContext ctx, Data.Entities.yetkiGruplariDetay model, IGrupRepository grupRepository)
        {
            if (model.grupId == null || model.grupId == 0)
                ctx.Insert(new Exception("Grup seçmeniz zorunludur"));
            var grup = await grupRepository.GetFirstOrDefaultAsync(q => q.id == model.grupId);
            if (grup == null)
                ctx.Insert(new Exception("Grup Sisteme Kayıtlı Değildir"));
        }

        private async Task YetkiKontrol(IContext ctx, Data.Entities.yetkiGruplariDetay model, IYetkilerRepository yetkilerRepository)
        {
            if (model.grupId == null || model.grupId == 0)
                ctx.Insert(new Exception("Grup seçmeniz zorunludur"));
            var grup = await yetkilerRepository.GetFirstOrDefaultAsync(q => q.id == model.yetkiId);
            if (grup == null)
                ctx.Insert(new Exception("Yetki  Sisteme Kayıtlı Değildir"));
        }
        
    }
}
