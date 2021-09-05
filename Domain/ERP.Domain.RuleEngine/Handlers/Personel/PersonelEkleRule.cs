using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.Blog.Rules.Personel
{
    [Tag("PersonelEkle")]
    public class PersonelEkleRule : BaseCustomValidationRule<ERP.Data.Entities.personel, IPersonelRepository, IKisiRepository>
    {
        protected override void Validate(IContext ctx, ERP.Data.Entities.personel model, IPersonelRepository personelRepository, IKisiRepository kisiRepository)
        {
            PersonelKontrol(ctx, model, personelRepository).Wait();
            //KisiKontrol(ctx, model, personelRepository).Wait();
            UnvanKontrol(ctx, model, personelRepository).Wait();
            KademeKontrol(ctx, model, personelRepository).Wait();
            BaslamaTarihKontrol(ctx, model, personelRepository).Wait();
            DurumKontrol(ctx, model, personelRepository).Wait();
            


        }
        private async Task PersonelKontrol(IContext ctx, Data.Entities.personel model, IPersonelRepository personelRepository)
        {
            var personel = await personelRepository.GetFirstOrDefaultAsyncWithIncludes(q => q.id == model.id, null, "unvan", "kademe");
            if (personel != null)
                ctx.Insert(new Exception(string.Format("{0} personeli Ünvan, Kademe olarak sisteme zaten kayıtlı", personel.adi + " " + personel.soyadi, personel.unvan.adi, personel.kademe.adi)));
        }

        private async Task UnvanKontrol(IContext ctx, Data.Entities.personel model, IPersonelRepository personelRepository)
        {
            if (model.unvanid == null || model.unvanid == 0)
                ctx.Insert(new Exception("Ünvan seçmeniz zorunludur"));
        }

        private async Task KademeKontrol(IContext ctx, Data.Entities.personel model, IPersonelRepository personelRepository)
        {
            if (model.kademeid == null || model.kademeid == 0)
                ctx.Insert(new Exception("Kademe seçmeniz zorunludur"));
        }

        //private async Task KisiKontrol(IContext ctx, Data.Entities.personel model, IPersonelRepository personelRepository)
        //{
        //    if (model.id == null || model.id == 0)
        //        ctx.Insert(new Exception("Kisi seçmeniz zorunludur"));
        //}

        private async Task BaslamaTarihKontrol(IContext ctx, Data.Entities.personel model, IPersonelRepository personelRepository)
        {
            if (model.iseGirisTarih < DateTime.Now.AddDays(-7))
                ctx.Insert(new Exception("Personel başlangıç tarihi 1 hafta öncesinden daha önce olamaz"));
        }

        private async Task DurumKontrol(IContext ctx, Data.Entities.personel model, IPersonelRepository personelRepository)
        {
            if (model.engellilikDurumid == 0)
                ctx.Insert(new Exception("Personel durumu girmeniz zorunludur"));
        }
    }
}
