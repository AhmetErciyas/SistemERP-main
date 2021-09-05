using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.Personel
{
    [Tag("PersonelGuncelle")]
    public class PersonelGuncelleRule : BaseCustomValidationRule<ERP.Data.Entities.personel, IPersonelRepository, IKisiRepository>
    {
        protected override void Validate(IContext ctx, ERP.Data.Entities.personel model, IPersonelRepository personelRepository, IKisiRepository kisiRepository)
        {
            //PersonelKontrol(ctx, model, personelRepository).Wait();
            //KisiKontrol(ctx, model, personelRepository).Wait();
            UnvanKontrol(ctx, model, personelRepository).Wait();
            KademeKontrol(ctx, model, personelRepository).Wait();
            BaslamaTarihKontrol(ctx, model, personelRepository).Wait();
            DurumKontrol(ctx, model, personelRepository).Wait();
            PersonelAgiPersonelKontrol(ctx, model, personelRepository).Wait();
            PersonelBankaHesapPersonelKontrol(ctx, model, personelRepository).Wait();
            PersonelDigerBilgilerPersonelKontrol(ctx, model, personelRepository).Wait();
            PersonelEmeklilikPersonelKontrol(ctx, model, personelRepository).Wait();
            PersonelKimlikPersonelKontrol(ctx, model, personelRepository).Wait();
            PersonelMaasPersonelKontrol(ctx, model, personelRepository).Wait();
            PersonelTabiKanunPersonelKontrol(ctx, model, personelRepository).Wait();


        }

        private async Task PersonelTabiKanunPersonelKontrol(IContext ctx, personel model, IPersonelRepository personelRepository)
        {
            if (model.personelTabiKanun.personelid == null || model.personelTabiKanun.personelid == 0)
                ctx.Insert(new Exception("Personel seçmeniz zorunludur"));
            var personel = await personelRepository.GetFirstOrDefaultAsync(q => q.id == model.personelTabiKanun.personelid);
            if (personel == null)
                ctx.Insert(new Exception("Personel Tabi Kanun Bilgiler Personel Bulunamadı"));
        }

        private async Task PersonelMaasPersonelKontrol(IContext ctx, personel model, IPersonelRepository personelRepository)
        {
            if (model.personelMaas.personelid == null || model.personelMaas.personelid == 0)
                ctx.Insert(new Exception("Personel seçmeniz zorunludur"));
            var personel = await personelRepository.GetFirstOrDefaultAsync(q => q.id == model.personelMaas.personelid);
            if (personel == null)
                ctx.Insert(new Exception("Personel Maas Bilgiler Personel Bulunamadı"));
        }

        private async Task PersonelKimlikPersonelKontrol(IContext ctx, personel model, IPersonelRepository personelRepository)
        {
            if (model.personelKimlik.personelid == null || model.personelKimlik.personelid == 0)
                ctx.Insert(new Exception("Personel seçmeniz zorunludur"));
            var personel = await personelRepository.GetFirstOrDefaultAsync(q => q.id == model.personelKimlik.personelid);
            if (personel == null)
                ctx.Insert(new Exception("Personel Kimlik Bilgiler Personel Bulunamadı"));
        }

        private async Task PersonelEmeklilikPersonelKontrol(IContext ctx, personel model, IPersonelRepository personelRepository)
        {
            if (model.personelEmeklilik.personelid == null || model.personelEmeklilik.personelid == 0)
                ctx.Insert(new Exception("Personel seçmeniz zorunludur"));
            var personel = await personelRepository.GetFirstOrDefaultAsync(q => q.id == model.personelEmeklilik.personelid);
            if (personel == null)
                ctx.Insert(new Exception("Personel Emeklilik Bilgiler Personel Bulunamadı"));
        }

        private async Task PersonelDigerBilgilerPersonelKontrol(IContext ctx, personel model, IPersonelRepository personelRepository)
        {
            if (model.digerBilgiler.personelid == null || model.digerBilgiler.personelid == 0)
                ctx.Insert(new Exception("Personel seçmeniz zorunludur"));
            var personel = await personelRepository.GetFirstOrDefaultAsync(q => q.id == model.digerBilgiler.personelid);
            if (personel == null)
                ctx.Insert(new Exception("Personel Diger Bilgiler Personel Bulunamadı"));
        }


        private async Task PersonelBankaHesapPersonelKontrol(IContext ctx, personel model, IPersonelRepository personelRepository)
        {
            if (model.personelBankaHesap.personelid == null || model.personelBankaHesap.personelid == 0)
                ctx.Insert(new Exception("Personel seçmeniz zorunludur"));
            var personel = await personelRepository.GetFirstOrDefaultAsync(q => q.id == model.personelBankaHesap.personelid);
            if (personel == null)
                ctx.Insert(new Exception("Personel Banka Hesap Personel Bulunamadı"));
        }
        private async Task PersonelAgiPersonelKontrol(IContext ctx, personel model, IPersonelRepository personelRepository)
        {
            if (model.personelAgi.personelid == null || model.personelAgi.personelid == 0)
                ctx.Insert(new Exception("Personel seçmeniz zorunludur"));
            var personel = await personelRepository.GetFirstOrDefaultAsync(q => q.id == model.personelAgi.personelid);
            if (personel == null)
                ctx.Insert(new Exception("Personel Agi Personel Bulunamadı"));
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