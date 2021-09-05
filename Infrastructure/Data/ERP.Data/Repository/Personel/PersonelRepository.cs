using ERP.Data.DAO.Personel;
using ERP.Data.DAO.PersonelAgi;
using ERP.Data.DAO.PersonelBankaHesap;
using ERP.Data.DAO.PersonelDepartman;
using ERP.Data.DAO.PersonelDiğerBilgileri;
using ERP.Data.DAO.PersonelEkGelirGider;
using ERP.Data.DAO.PersonelEmeklilik;
using ERP.Data.DAO.PersonelKimlikBilgileri;
using ERP.Data.DAO.PersonelMaas;
using ERP.Data.DAO.PersonelTabiKanun;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Data.Repository
{
    public class PersonelRepository : BaseRepository<personel>, IPersonelRepository
    {
        public PersonelRepository(DataContext context)
        : base(context)
        {
        }

        public async Task<List<PersonelDAO>> PersonelAra(PersonelAraDAO model)
        {
            var query = _dbSet.Select(x => new PersonelDAO()
            {
                id = x.id,
                subeid = x.subeid,
                subeadi = x.sube.adi,
                kademeid = x.kademeid,
                kademeAdi = x.kademe.adi,
                unvanid = x.unvanid,
                unvanAdi = x.unvan.adi,
                sigortaTurid = x.sigortaTurid,
                sigortaTurAdi = x.sigortaTur.adi,
                sigortaDurumid = x.sigortaDurumid,
                sigortaDurumAdi = x.sigortaDurum.adi,
                meslekid = x.meslekid,
                //meslekadi =x.mes
                grupid = x.grupid,
                grupadi = x.grup.adi,
                askerlikDurumid = x.askerlikDurumid,
                askerlikDurumAdi = x.askerlikDurum.adi,
                sicilNo = x.sicilNo,
                adi = x.adi,
                soyadi = x.soyadi,
                vergiDaireid = x.vergiDaireid,
                vergiDaireAdi = x.vergiDaire.ad,
                vergiNo = x.vergiNo,
                sigortaNo = x.sigortaNo,
                iseGirisTarih = x.iseGirisTarih,
                isdenCikisTarih = x.isdenCikisTarih,
                ogrenimDurumid = x.ogrenimDurumid,
                ogrenimDurumAdi = x.ogrenimDurum.adi,
                okul = x.okul,
                bolum = x.bolum,
                mezuniyetTarih = x.mezuniyetTarih,
                engellilikDurumid = x.engellilikDurumid,
                engellilikDurumAdi = x.engellilikDurum.adi,
                engellilikIndirim = x.engellilikIndirim,
                eskiHukumlu = x.eskiHukumlu,
                terorMagduru = x.terorMagduru,
                sozlesmeTurid = x.sozlesmeTurid,
                sozlesmeTurAdi = x.sozlesmeTur.adi,
                sozlesmeBitisTarih = x.sozlesmeBitisTarih,
                kidemTarih = x.kidemTarih,
                firmaid = x.firmaid,
                firmaadi = x.firma.adi,
                departmanid = x.departmanid,
                departmanadi = x.departman.adi,
                istenAyrilmaNedenid = x.istenAyrilmaNedenid,
                istenAyrilmaNedenAdi = x.istenAyrilmaNeden.adi,
                personelAgiDto = _dbContext.personelAgi.Where(y => y.personelid == x.id).Select(z => new PersonelAgiDAO()
                {
                    id = z.personelid,
                    esCalisiyorMu = z.esCalisiyorMu,
                    esinGeliriVarMi = z.esinGeliriVarMi,
                    AgiKapsamindaCocukSayisi = z.AgiKapsamindaCocukSayisi,
                    digerCocuk = z.digerCocuk
                }).FirstOrDefault(),
                personelBankaHesapDto = _dbContext.personelBankaHesap.Where(y => y.personelid == x.id).Select(z => new PersonelBankaHesapDAO()
                {
                    kodu = z.kodu,
                    adi = z.adi,
                    paraBirimiid = z.paraBirimiid,
                    //paraBirimAdi=z.para
                    subeno = z.subeno,
                    subeAdi = z.subeAdi,
                    hesapNo = z.hesapNo,
                    ibanNo = z.ibanNo,
                    anaHesap = z.anaHesap,
                }).FirstOrDefault(),
                personelDepartmanDTO = _dbContext.personelDepartman.Where(y => y.personelid == x.id).Select(z => new PersonelDepartmanDAO()
                {
                    departmanid = z.departmanid,
                    departmanAdi = z.departman.adi,
                    yoneticiMi = z.yoneticiMi,
                    vekilMi = z.vekilMi
                }).ToList(),
                personelDiğerBilgileriDTO = _dbContext.digerBilgiler.Where(y => y.personelid == x.id).Select(z => new PersonelDiğerBilgileriDAO()
                {
                    emekliSandikNo = z.emekliSandikNo,
                    bagkurNo = z.bagkurNo,
                    sandikKodu = z.sandikKodu,
                    sicilNo = z.sicilNo,
                    sosyalGuvenlikKurumid = z.sosyalGuvenlikKurumid,
                    referansAdSoyad = z.referansAdSoyad,
                    oncekiIsyeri = z.oncekiIsyeri,
                    oncekiCalismaSuresiAy = z.oncekiCalismaSuresiAy,
                    oncekiIsAdres = z.oncekiIsAdres
                }).FirstOrDefault(),
                PersonelEkGelirGiderDTO = _dbContext.ekGelirGider.Where(y => y.personelid == x.id).Select(z => new PersonelEkGelirGiderDAO()
                {
                    ekGelirGiderTur = z.ekGelirGiderTur,
                    ekGelirGiderTurAdi = z.ekGelirGiderTurNavigation.adi,
                    ekGelirGiderAciklamaAdi = z.ekGelirGiderAciklamaNavigation.adi,
                    ekGelirGiderAciklama = z.ekGelirGiderAciklama,
                    ucretlendirmeTur = z.ucretlendirmeTur,
                    birim = z.birim,
                    tutar = z.tutar,
                    netMi = z.netMi,
                    BaslangicTarih = z.BaslangicTarih,
                    BitisTarih = z.BitisTarih

                }).ToList(),
                personelEmeklilikDTO = _dbContext.personelEmeklilik.Where(y => y.personelid == x.id).Select(z => new PersonelEmeklilikDAO()
                {
                    ozelSigortaTurid = z.ozelSigortaTurid,
                    //ozelSigortaTurAdi =z.ozelSigortaTurid
                    bireyselEmeklilikVar = z.bireyselEmeklilikVar,
                    EmeklilikKesintiOran = z.EmeklilikKesintiOran,
                    policeNo = z.policeNo,
                    PTOemeklilik = z.PTOemeklilik,
                    PTOhayat = z.PTOhayat,
                    PTOsaglik = z.PTOsaglik,
                    ITOemeklilik = z.ITOemeklilik,
                    ITOhayat = z.ITOhayat,
                    ITOsaglik = z.ITOsaglik,
                }).FirstOrDefault(),
                personelKimlikBilgileriDTO = _dbContext.personelKimlik.Where(y => y.personelid == x.id).Select(z => new PersonelKimlikBilgileriDAO()
                {
                    kimlikTurid = z.kimlikTurid,
                    kimlikTurAdi = z.kimlikTur.adi,
                    medeniHal = z.medeniHal,
                    cinsiyet = z.cinsiyet,
                    seriNo = z.seriNo,
                    tckNo = z.tckNo,
                    kanGrup = z.kanGrup,
                    //kanGrupAdi = z.kanGrup.,
                    babaAdi = z.babaAdi,
                    anneAdi = z.anneAdi,
                    dogumYeri = z.dogumYeri,
                    dogumTarih = z.dogumTarih,
                    ulkeid = z.ulkeid,
                    ulkeAdi = z.ulke.adi,
                    ilid = z.ilid,
                    iladi = z.il.adi,
                    ilceid = z.ilceid,
                    ilceadi = z.ilce.adi,
                    mahalleid = z.mahalleid,
                    //mahalleAdi = z.mahalleid,
                    hesKodu = z.hesKodu,
                    ehliyetVarMi = z.ehliyetVarMi,
                    uyrukid = z.kimlikTurid,
                    uyrukAdi = z.kimlikTurid,
                    oncekiSoyadi = z.oncekiSoyadi,
                    verilisTarih = z.verilisTarih,
                    verildigiYer = z.verildigiYer,
                    verilisNedeni = z.verilisNedeni,
                    siraNo = z.siraNo,
                    ciltNo = z.ciltNo,
                    aileSiraNo = z.aileSiraNo,
                    kayitNo = z.kayitNo,
                    eposta = z.eposta,
                }).FirstOrDefault(),
                personelMaasDTO = _dbContext.personelMaas.Where(y => y.personelid == x.id).Select(z => new PersonelMaasDAO()
                {
                    maas = z.maas,
                    maasParaBirimid = z.maasParaBirimid,
                    maasParaBirimAdi = z.maasParaBirim.adi,
                    maasbrut = z.maasbrut,
                    asgariUcret = z.asgariUcret,
                    personelMaasOdemeTurid = z.personelMaasOdemeTurid,
                    personelMaasOdemeTurAdi = z.personelMaasOdemeTur.adi,
                    personelMaasPeriyotid = z.personelMaasPeriyotid,
                    personelMaasPeriyotAdi = z.personelMaasPeriyot.adi,
                    baslangicTarih = z.baslangicTarih,
                    bitisTarih = z.bitisTarih
                }).FirstOrDefault(),
                personelTabiKanunDTO = _dbContext.personelTabiKanun.Where(y => y.personelid == x.id).Select(z => new PersonelTabiKanunDAO()
                {
                    GVHesaplansinMi = z.GVHesaplansinMi,
                    GVmuafiyet = z.GVmuafiyet,
                    GVMuafiyetiNeteEkle = z.GVMuafiyetiNeteEkle,
                    SGKHesaplansinMi = z.SGKHesaplansinMi,
                    UVSKisveren = z.UVSKisveren,
                    UVSKisci = z.UVSKisci,
                    GSSisveren = z.GSSisveren,
                    GSSisci = z.GSSisci,
                    KVSKisveren = z.KVSKisveren,
                    IssizlikHesaplansinMi = z.IssizlikHesaplansinMi,
                    Issizlikisveren = z.Issizlikisveren,
                    Issizlikisci = z.Issizlikisci,
                    DVHesaplansinMi = z.DVHesaplansinMi,
                    DamgaVergisi = z.DamgaVergisi,
                    DVMuafiyetiNeteEkle = z.DVMuafiyetiNeteEkle,
                }).FirstOrDefault(),
            }).OrderBy(x => x.id).AsQueryable();

            if (model.PersonelId.HasValue)
                query = query.Where(f => f.id == model.PersonelId.Value);
            if (model.KademeId.HasValue)
                query = query.Where(f => f.id == model.KademeId.Value);
            if (model.UnvanId.HasValue)
                query = query.Where(f => f.id == model.UnvanId.Value);
            //if (model.KisiId.HasValue)
            //    query = query.Where(c => c.KisiId == model.KisiId.Value);

            if (!string.IsNullOrWhiteSpace(model.SicilNo))
                query = query.Where(c => c.sicilNo == model.SicilNo);

            if (!string.IsNullOrWhiteSpace(model.SigortaNo))
                query = query.Where(c => c.sigortaNo == model.SigortaNo);

            //if (model.DurumId.HasValue)
            //    query = query.Where(c => c.dur == model.DurumId);

            return await query.ToListAsync();
        }

        public Task<PersonelDAO> PersonelGetir(int PersonelId)
        {
            return _dbSet.Where(t => t.id == PersonelId).Select(x => new PersonelDAO()
            {
                id = x.id,
                subeid = x.subeid,
                subeadi = x.sube.adi,
                kademeid = x.kademeid,
                kademeAdi = x.kademe.adi,
                unvanid = x.unvanid,
                unvanAdi = x.unvan.adi,
                sigortaTurid = x.sigortaTurid,
                sigortaTurAdi = x.sigortaTur.adi,
                sigortaDurumid = x.sigortaDurumid,
                sigortaDurumAdi = x.sigortaDurum.adi,
                meslekid = x.meslekid,
                //meslekadi =x.mes
                grupid = x.grupid,
                grupadi = x.grup.adi,
                askerlikDurumid = x.askerlikDurumid,
                askerlikDurumAdi = x.askerlikDurum.adi,
                sicilNo = x.sicilNo,
                adi = x.adi,
                soyadi = x.soyadi,
                vergiDaireid = x.vergiDaireid,
                vergiDaireAdi = x.vergiDaire.ad,
                vergiNo = x.vergiNo,
                sigortaNo = x.sigortaNo,
                iseGirisTarih = x.iseGirisTarih,
                isdenCikisTarih = x.isdenCikisTarih,
                ogrenimDurumid = x.ogrenimDurumid,
                ogrenimDurumAdi = x.ogrenimDurum.adi,
                okul = x.okul,
                bolum = x.bolum,
                mezuniyetTarih = x.mezuniyetTarih,
                engellilikDurumid = x.engellilikDurumid,
                engellilikDurumAdi = x.engellilikDurum.adi,
                engellilikIndirim = x.engellilikIndirim,
                eskiHukumlu = x.eskiHukumlu,
                terorMagduru = x.terorMagduru,
                sozlesmeTurid = x.sozlesmeTurid,
                sozlesmeTurAdi = x.sozlesmeTur.adi,
                sozlesmeBitisTarih = x.sozlesmeBitisTarih,
                kidemTarih = x.kidemTarih,
                firmaid = x.firmaid,
                firmaadi = x.firma.adi,
                departmanid = x.departmanid,
                departmanadi = x.departman.adi,
                istenAyrilmaNedenid = x.istenAyrilmaNedenid,
                istenAyrilmaNedenAdi = x.istenAyrilmaNeden.adi,
                personelAgiDto = _dbContext.personelAgi.Where(y => y.personelid == x.id).Select(z => new PersonelAgiDAO()
                {
                    id = z.personelid,
                    esCalisiyorMu = z.esCalisiyorMu,
                    esinGeliriVarMi = z.esinGeliriVarMi,
                    AgiKapsamindaCocukSayisi = z.AgiKapsamindaCocukSayisi,
                    digerCocuk = z.digerCocuk
                }).FirstOrDefault(),
                personelBankaHesapDto = _dbContext.personelBankaHesap.Where(y => y.personelid == x.id).Select(z => new PersonelBankaHesapDAO()
                {
                    kodu = z.kodu,
                    adi = z.adi,
                    paraBirimiid = z.paraBirimiid,
                    //paraBirimAdi=z.para
                    subeno = z.subeno,
                    subeAdi = z.subeAdi,
                    hesapNo = z.hesapNo,
                    ibanNo = z.ibanNo,
                    anaHesap = z.anaHesap,
                }).FirstOrDefault(),
                personelDepartmanDTO = _dbContext.personelDepartman.Where(y => y.personelid == x.id).Select(z => new PersonelDepartmanDAO()
                {
                    departmanid = z.departmanid,
                    departmanAdi = z.departman.adi,
                    yoneticiMi = z.yoneticiMi,
                    vekilMi = z.vekilMi
                }).ToList(),
                personelDiğerBilgileriDTO = _dbContext.digerBilgiler.Where(y => y.personelid == x.id).Select(z => new PersonelDiğerBilgileriDAO()
                {
                    emekliSandikNo = z.emekliSandikNo,
                    bagkurNo = z.bagkurNo,
                    sandikKodu = z.sandikKodu,
                    sicilNo = z.sicilNo,
                    sosyalGuvenlikKurumid = z.sosyalGuvenlikKurumid,
                    referansAdSoyad = z.referansAdSoyad,
                    oncekiIsyeri = z.oncekiIsyeri,
                    oncekiCalismaSuresiAy = z.oncekiCalismaSuresiAy,
                    oncekiIsAdres = z.oncekiIsAdres
                }).FirstOrDefault(),
                PersonelEkGelirGiderDTO = _dbContext.ekGelirGider.Where(y => y.personelid == x.id).Select(z => new PersonelEkGelirGiderDAO()
                {
                    ekGelirGiderTur = z.ekGelirGiderTur,
                    ekGelirGiderTurAdi = z.ekGelirGiderTurNavigation.adi,
                    ekGelirGiderAciklamaAdi = z.ekGelirGiderAciklamaNavigation.adi,
                    ekGelirGiderAciklama = z.ekGelirGiderAciklama,
                    ucretlendirmeTur = z.ucretlendirmeTur,
                    birim = z.birim,
                    tutar = z.tutar,
                    netMi = z.netMi,
                    BaslangicTarih = z.BaslangicTarih,
                    BitisTarih = z.BitisTarih

                }).ToList(),
                personelEmeklilikDTO = _dbContext.personelEmeklilik.Where(y => y.personelid == x.id).Select(z => new PersonelEmeklilikDAO()
                {
                    ozelSigortaTurid = z.ozelSigortaTurid,
                    //ozelSigortaTurAdi =z.ozelSigortaTurid
                    bireyselEmeklilikVar = z.bireyselEmeklilikVar,
                    EmeklilikKesintiOran = z.EmeklilikKesintiOran,
                    policeNo = z.policeNo,
                    PTOemeklilik = z.PTOemeklilik,
                    PTOhayat = z.PTOhayat,
                    PTOsaglik = z.PTOsaglik,
                    ITOemeklilik = z.ITOemeklilik,
                    ITOhayat = z.ITOhayat,
                    ITOsaglik = z.ITOsaglik,
                }).FirstOrDefault(),
                personelKimlikBilgileriDTO = _dbContext.personelKimlik.Where(y => y.personelid == x.id).Select(z => new PersonelKimlikBilgileriDAO()
                {
                    kimlikTurid = z.kimlikTurid,
                    kimlikTurAdi = z.kimlikTur.adi,
                    medeniHal = z.medeniHal,
                    cinsiyet = z.cinsiyet,
                    seriNo = z.seriNo,
                    tckNo = z.tckNo,
                    kanGrup = z.kanGrup,
                    //kanGrupAdi = z.kanGrup.,
                    babaAdi = z.babaAdi,
                    anneAdi = z.anneAdi,
                    dogumYeri = z.dogumYeri,
                    dogumTarih = z.dogumTarih,
                    ulkeid = z.ulkeid,
                    ulkeAdi = z.ulke.adi,
                    ilid = z.ilid,
                    iladi = z.il.adi,
                    ilceid = z.ilceid,
                    ilceadi = z.ilce.adi,
                    mahalleid = z.mahalleid,
                    //mahalleAdi = z.mahalleid,
                    hesKodu = z.hesKodu,
                    ehliyetVarMi = z.ehliyetVarMi,
                    uyrukid = z.kimlikTurid,
                    uyrukAdi = z.kimlikTurid,
                    oncekiSoyadi = z.oncekiSoyadi,
                    verilisTarih = z.verilisTarih,
                    verildigiYer = z.verildigiYer,
                    verilisNedeni = z.verilisNedeni,
                    siraNo = z.siraNo,
                    ciltNo = z.ciltNo,
                    aileSiraNo = z.aileSiraNo,
                    kayitNo = z.kayitNo,
                    eposta = z.eposta,
                }).FirstOrDefault(),
                personelMaasDTO = _dbContext.personelMaas.Where(y => y.personelid == x.id).Select(z => new PersonelMaasDAO()
                {
                    maas = z.maas,
                    maasParaBirimid = z.maasParaBirimid,
                    maasParaBirimAdi = z.maasParaBirim.adi,
                    maasbrut = z.maasbrut,
                    asgariUcret = z.asgariUcret,
                    personelMaasOdemeTurid = z.personelMaasOdemeTurid,
                    personelMaasOdemeTurAdi = z.personelMaasOdemeTur.adi,
                    personelMaasPeriyotid = z.personelMaasPeriyotid,
                    personelMaasPeriyotAdi = z.personelMaasPeriyot.adi,
                    baslangicTarih = z.baslangicTarih,
                    bitisTarih = z.bitisTarih
                }).FirstOrDefault(),
                personelTabiKanunDTO = _dbContext.personelTabiKanun.Where(y => y.personelid == x.id).Select(z => new PersonelTabiKanunDAO()
                {
                    GVHesaplansinMi = z.GVHesaplansinMi,
                    GVmuafiyet = z.GVmuafiyet,
                    GVMuafiyetiNeteEkle = z.GVMuafiyetiNeteEkle,
                    SGKHesaplansinMi = z.SGKHesaplansinMi,
                    UVSKisveren = z.UVSKisveren,
                    UVSKisci = z.UVSKisci,
                    GSSisveren = z.GSSisveren,
                    GSSisci = z.GSSisci,
                    KVSKisveren = z.KVSKisveren,
                    IssizlikHesaplansinMi = z.IssizlikHesaplansinMi,
                    Issizlikisveren = z.Issizlikisveren,
                    Issizlikisci = z.Issizlikisci,
                    DVHesaplansinMi = z.DVHesaplansinMi,
                    DamgaVergisi = z.DamgaVergisi,
                    DVMuafiyetiNeteEkle = z.DVMuafiyetiNeteEkle,
                }).FirstOrDefault(),
            }).FirstOrDefaultAsync();
        }
    }
}