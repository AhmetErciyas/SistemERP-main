using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.PersonelİzinGrup
{
    [Tag("IzinGrupEkle")]
    public class IzinGrupEkleRule : BaseCustomValidationRule<ERP.Data.Entities.izinGrubu, IIzinGrubuRepository>
    {
        protected override void Validate(IContext ctx, izinGrubu model, IIzinGrubuRepository ızinGrupRepository)
        {
            NameKontrol(ctx, model, ızinGrupRepository).Wait();
        }

        private async Task NameKontrol(IContext ctx, izinGrubu model, IIzinGrubuRepository ızinGrupRepository)
        {
            var grup = await ızinGrupRepository.GetFirstOrDefaultAsync(q => q.adi == model.adi);
            if (grup != null)
                ctx.Insert(new Exception("Bu isimde Kayıt Bulunmaktadır"));
        }
    }
}
