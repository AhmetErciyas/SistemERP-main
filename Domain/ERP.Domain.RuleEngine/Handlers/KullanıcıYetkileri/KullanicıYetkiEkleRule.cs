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
    [Tag("KullanicıYetkiEkle")]
    public class KullanicıYetkiEkleRule : BaseCustomValidationRule<ERP.Data.Entities.kullaniciYetkileri, IKullaniciRepository, IYetkilerRepository>
    {
        
        protected override void Validate(IContext ctx, kullaniciYetkileri model, IKullaniciRepository kullaniciRepository, IYetkilerRepository yetkilerRepository)
        {
            YetkiKontrol(ctx, model, yetkilerRepository).Wait();
           KullaniciKontrol(ctx, model, kullaniciRepository).Wait();
        }

        private async Task KullaniciKontrol(IContext ctx, kullaniciYetkileri model, IKullaniciRepository kullaniciRepository)
        {
            if (model.kullaniciId == null || model.kullaniciId == 0)
                ctx.Insert(new Exception("Kullanıcı seçmeniz zorunludur"));
            var grup = await kullaniciRepository.GetFirstOrDefaultAsync(q => q.id == model.kullaniciId);
            if (grup == null)
                ctx.Insert(new Exception("Kullanıcı Sisteme Kayıtlı Değildir"));
        }

        private async Task YetkiKontrol(IContext ctx, kullaniciYetkileri model, IYetkilerRepository yetkilerRepository)
        {
            if (model.yetkiId == null || model.yetkiId == 0)
                ctx.Insert(new Exception("Yetki seçmeniz zorunludur"));
            var grup = await yetkilerRepository.GetFirstOrDefaultAsync(q => q.id == model.yetkiId);
            if (grup == null)
                ctx.Insert(new Exception("Yetki Sisteme Kayıtlı Değildir"));
        }
    }
}
