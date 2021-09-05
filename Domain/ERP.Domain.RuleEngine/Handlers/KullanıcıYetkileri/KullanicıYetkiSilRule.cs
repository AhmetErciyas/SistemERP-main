using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.KullanıcıYetkileri
{
    [Tag("KullanicıYetkiSil")]
    public class KullanicıYetkiSilRule : BaseCustomValidationRule<ERP.Data.Entities.kullaniciYetkileri, IKullaniciYetkileriRepository>
    {
        
       

        protected override void Validate(IContext ctx, kullaniciYetkileri model, IKullaniciYetkileriRepository kullaniciYetkilerRepository)
        {
            YetkiGrupDetayKontrol(ctx, model, kullaniciYetkilerRepository).Wait();
        }

        private async Task YetkiGrupDetayKontrol(IContext ctx, kullaniciYetkileri model, IKullaniciYetkileriRepository kullaniciYetkilerRepository)
        {
            if (model.id == null || model.id == 0)
                ctx.Insert(new Exception("... seçmeniz zorunludur"));
            var grup = kullaniciYetkilerRepository.GetFirstOrDefaultAsync(q => q.id == model.id);
            if (grup == null)
                ctx.Insert(new Exception("Kayıt Sisteme Kayıtlı Değildir"));
        }
    }
}
