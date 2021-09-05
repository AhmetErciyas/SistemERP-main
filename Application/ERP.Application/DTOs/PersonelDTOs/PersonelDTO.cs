using ERP.Application.DTOs.PersonelAgiDTOs;
using ERP.Application.DTOs.PersonelBankaHesapDTOs;
using ERP.Application.DTOs.PersonelDepartmanDTOs;
using ERP.Application.DTOs.PersonelDiğerBilgileriDTOS;
using ERP.Application.DTOs.PersonelEkGelirGiderDTOs;
using ERP.Application.DTOs.PersonelEmeklilikDTOs;
using ERP.Application.DTOs.PersonelKimlikBilgileriDTOs;
using ERP.Application.DTOs.PersonelMaasDTOs;
using ERP.Application.DTOs.PersonelTabiKanunDTOs;
using System;
using System.Collections.Generic;

namespace ERP.Application.DTOs.PersonelDTOs
{
    public class PersonelEkleDTO
    {
        public int? firmaid { get; set; }
        public int kademeid { get; set; }
        public int unvanid { get; set; }
        public int sigortaTurid { get; set; }
        public int sigortaDurumid { get; set; }
        public int meslekid { get; set; }
        public int grupid { get; set; }
        public int askerlikDurumid { get; set; }
        public string sicilNo { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int? vergiDaireid { get; set; }
        public string vergiNo { get; set; }
        public string sigortaNo { get; set; }
        public DateTime? iseGirisTarih { get; set; }
        public DateTime? isdenCikisTarih { get; set; }
        public int? ogrenimDurumid { get; set; }
        public string okul { get; set; }
        public string bolum { get; set; }
        public DateTime? mezuniyetTarih { get; set; }
        public int? engellilikDurumid { get; set; }
        public bool? engellilikIndirim { get; set; }
        public bool? eskiHukumlu { get; set; }
        public bool? terorMagduru { get; set; }
        public int? sozlesmeTurid { get; set; }
        public DateTime? sozlesmeBitisTarih { get; set; }
        public DateTime? kidemTarih { get; set; }
        public int? personelMaasid { get; set; }
        public int? personelBankaHesapid { get; set; }
        public int? personelKimlikid { get; set; }
        public PersonelAgiEkleDto PersonelAgiEkleDto { get; set; }
        public PersonelBankaHesapEkleDto PersonelBankaHesapEkleDto { get; set; }
        public ICollection<PersonelDepartmanEkleDTO> PersonelDepartmanEkleDTO { get; set; }
        public PersonelDiğerBilgileriEkleDTO PersonelDiğerBilgileriEkleDTO { get; set; }
        public ICollection<PersonelEkGelirGiderEkleDTO> PersonelEkGelirGiderEkleDTO { get; set; }
        public PersonelKimlikBilgileriEkleDTO PersonelKimlikBilgileriEkleDTO { get; set; }
        public PersonelMaasEkleDTO PersonelMaasEkleDTO { get; set; }
        public PersonelTabiKanunEkleDTO PersonelTabiKanunEkleDTO { get; set; }
        public PersonelEmeklilikEkleDTO PersonelEmeklilikEkleDTO { get; set; }


    }

    public class PersonelGuncelleDTO
    {
        public int id { get; set; }
        public int? firmaid { get; set; }
        public int kademeid { get; set; }
        public int unvanid { get; set; }
        public int sigortaTurid { get; set; }
        public int sigortaDurumid { get; set; }
        public int meslekid { get; set; }
        public int grupid { get; set; }
        public int askerlikDurumid { get; set; }
        public string sicilNo { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int? vergiDaireid { get; set; }
        public string vergiNo { get; set; }
        public string sigortaNo { get; set; }
        public DateTime? iseGirisTarih { get; set; }
        public DateTime? isdenCikisTarih { get; set; }
        public int? ogrenimDurumid { get; set; }
        public string okul { get; set; }
        public string bolum { get; set; }
        public DateTime? mezuniyetTarih { get; set; }
        public int? engellilikDurumid { get; set; }
        public bool? engellilikIndirim { get; set; }
        public bool? eskiHukumlu { get; set; }
        public bool? terorMagduru { get; set; }
        public int? sozlesmeTurid { get; set; }
        public DateTime? sozlesmeBitisTarih { get; set; }
        public DateTime? kidemTarih { get; set; }
        public int? personelMaasid { get; set; }
        public int? personelBankaHesapid { get; set; }
        public int? personelKimlikid { get; set; }
        public PersonelAgiGuncelleDto PersonelAgiGuncelleDto { get; set; }
        public  PersonelBankaHesapGuncelleDto PersonelBankaHesapGuncelleDto { get; set; }
        public  ICollection<PersonelDepartmanGuncelleDTO> PersonelDepartmanGuncelleDTO { get; set; }
        public  PersonelDiğerBilgileriGuncelleDTO PersonelDiğerBilgileriGuncelleDTO { get; set; }
        public  ICollection<PersonelEkGelirGiderGuncelleDTO> PersonelEkGelirGiderGuncelleDTO { get; set; }
        public  PersonelKimlikBilgileriGuncelleDTO PersonelKimlikBilgileriGuncelleDTO { get; set; }
        public  PersonelMaasGuncelleDTO PersonelMaasGuncelleDTO { get; set; }
        public  PersonelTabiKanunGuncelleDTO PersonelTabiKanunGuncelleDTO { get; set; }
        public  PersonelEmeklilikGuncelleDTO personelEmeklilikGuncelleDTO { get; set; }
    }

    public class PersonelAraDTO 
    {
        public int? PersonelId { get; set; }
        public string SigortaNo { get; set; }
        public string SicilNo { get; set; }
        public int? KademeId { get; set; }
        public int? UnvanId { get; set; }
        public short? DurumId { get; set; }
        public int? KisiId { get; set; }
    }

    public class PersonelKisiEkleDTO
    {
        public int Id { get; set; }
        public DateTime BaslamaTarih { get; set; }
        public string SigortaNo { get; set; }
        public string SicilNo { get; set; }
        public int? KademeId { get; set; }
        public int? UnvanId { get; set; }
        public short DurumId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public short KisiDurumId { get; set; }
        public string KisiDurumAd { get; set; }
        public short? CinsiyetId { get; set; }
        public string CinsiyetAd { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string TCKN { get; set; }
        public short? KanGrupId { get; set; }
        public string KanGrupAd { get; set; }
        public short? MedeniHalId { get; set; }
        public string MedeniHalAd { get; set; }
        public string IBANHesapNo { get; set; }
    }

    public class PersonelDTO
    {
        public int id { get; set; }
        public int? subeid { get; set; }
        public string subeadi { get; set; }
        public int kademeid { get; set; }
        public string kademeAdi { get; set; }
        public int unvanid { get; set; }
        public string unvanAdi { get; set; }
        public int sigortaTurid { get; set; }
        public string sigortaTurAdi { get; set; }
        public int sigortaDurumid { get; set; }
        public string sigortaDurumAdi { get; set; }
        public int? meslekid { get; set; }
        public string meslekadi { get; set; }
        public int? grupid { get; set; }
        public string grupadi { get; set; }
        public int askerlikDurumid { get; set; }
        public string askerlikDurumAdi { get; set; }
        public string sicilNo { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int? vergiDaireid { get; set; }
        public string vergiDaireAdi { get; set; }
        public string vergiNo { get; set; }
        public string sigortaNo { get; set; }
        public DateTime? iseGirisTarih { get; set; }
        public DateTime? isdenCikisTarih { get; set; }
        public int? ogrenimDurumid { get; set; }
        public string ogrenimDurumAdi { get; set; }
        public string okul { get; set; }
        public string bolum { get; set; }
        public DateTime? mezuniyetTarih { get; set; }
        public int? engellilikDurumid { get; set; }
        public string engellilikDurumAdi { get; set; }
        public bool? engellilikIndirim { get; set; }
        public bool? eskiHukumlu { get; set; }
        public bool? terorMagduru { get; set; }
        public int? sozlesmeTurid { get; set; }
        public string sozlesmeTurAdi { get; set; }
        public DateTime? sozlesmeBitisTarih { get; set; }
        public DateTime? kidemTarih { get; set; }
        public int? firmaid { get; set; }
        public string firmaadi { get; set; }
        public int? departmanid { get; set; }
        public string departmanadi { get; set; }
        public int? istenAyrilmaNedenid { get; set; }
        public string istenAyrilmaNedenAdi { get; set; }
        public string AdSoyad
        {
            get
            {
                return string.Format("{0} {1}", adi, soyadi);
            }
        }
        
        public PersonelAgiDto personelAgiDto { get; set; }
        public PersonelBankaHesapDto personelBankaHesapDto { get; set; }
        public List<PersonelDepartmanDTO> personelDepartmanDTO { get; set; }
        public PersonelDiğerBilgileriDTO personelDiğerBilgileriDTO { get; set; }
        public List<PersonelEkGelirGiderDTO> PersonelEkGelirGiderDTO { get; set; }
        public PersonelEmeklilikDTO personelEmeklilikDTO { get; set; }
        public PersonelKimlikBilgileriDTO personelKimlikBilgileriDTO { get; set; }
        public PersonelTabiKanunDTO personelTabiKanunDTO { get; set; }
        public PersonelMaasDTO personelMaasDTO { get; set; }
     

    }
}
