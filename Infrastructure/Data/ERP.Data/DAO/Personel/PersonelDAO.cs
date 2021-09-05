using ERP.Data.DAO.PersonelAgi;
using ERP.Data.DAO.PersonelBankaHesap;
using ERP.Data.DAO.PersonelDepartman;
using ERP.Data.DAO.PersonelDiğerBilgileri;
using ERP.Data.DAO.PersonelEkGelirGider;
using ERP.Data.DAO.PersonelEmeklilik;
using ERP.Data.DAO.PersonelKimlikBilgileri;
using ERP.Data.DAO.PersonelMaas;
using ERP.Data.DAO.PersonelTabiKanun;
using System;
using System.Collections.Generic;

namespace ERP.Data.DAO.Personel
{
    public class PersonelDAO
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

        public PersonelAgiDAO personelAgiDto { get; set; }
        public PersonelBankaHesapDAO personelBankaHesapDto { get; set; }
        public List<PersonelDepartmanDAO> personelDepartmanDTO { get; set; }
        public PersonelDiğerBilgileriDAO personelDiğerBilgileriDTO { get; set; }
        public List<PersonelEkGelirGiderDAO> PersonelEkGelirGiderDTO { get; set; }
        public PersonelEmeklilikDAO personelEmeklilikDTO { get; set; }
        public PersonelKimlikBilgileriDAO personelKimlikBilgileriDTO { get; set; }
        public PersonelTabiKanunDAO personelTabiKanunDTO { get; set; }
        public PersonelMaasDAO personelMaasDTO { get; set; }
    }
}
