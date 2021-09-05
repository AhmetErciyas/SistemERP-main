using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelKimlikBilgileri
{
    public class PersonelKimlikBilgileriDAO
    {
        public int kimlikTurid { get; set; }
        public string kimlikTurAdi { get; set; }
        public int? medeniHal { get; set; }
        public bool? cinsiyet { get; set; }
        public string seriNo { get; set; }
        public string tckNo { get; set; }
        public int? kanGrup { get; set; }
        public string kanGrupAdi { get; set; }
        public string babaAdi { get; set; }
        public string anneAdi { get; set; }
        public string dogumYeri { get; set; }
        public DateTime? dogumTarih { get; set; }
        public int? ulkeid { get; set; }
        public string ulkeAdi { get; set; }
        public int? ilid { get; set; }
        public string iladi { get; set; }
        public int? ilceid { get; set; }
        public string ilceadi { get; set; }
        public int? mahalleid { get; set; }
        public int? mahalleAdi { get; set; }
        public string hesKodu { get; set; }
        public bool? ehliyetVarMi { get; set; }
        public int? uyrukid { get; set; }
        public int? uyrukAdi { get; set; }
        public string oncekiSoyadi { get; set; }
        public DateTime? verilisTarih { get; set; }
        public string verildigiYer { get; set; }
        public string verilisNedeni { get; set; }
        public string siraNo { get; set; }
        public string ciltNo { get; set; }
        public string aileSiraNo { get; set; }
        public string kayitNo { get; set; }
        public string eposta { get; set; }
    }
}
