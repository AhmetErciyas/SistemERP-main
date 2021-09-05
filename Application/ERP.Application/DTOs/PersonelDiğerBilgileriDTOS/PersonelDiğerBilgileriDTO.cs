using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.PersonelDiğerBilgileriDTOS
{
    public class PersonelDiğerBilgileriDTO
    {

        public string emekliSandikNo { get; set; }
        public string bagkurNo { get; set; }
        public string sandikKodu { get; set; }
        public string sicilNo { get; set; }
        public int sosyalGuvenlikKurumid { get; set; }
        public string referansAdSoyad { get; set; }
        public string oncekiIsyeri { get; set; }
        public int? oncekiCalismaSuresiAy { get; set; }
        public string oncekiIsAdres { get; set; }
    }
    public class PersonelDiğerBilgileriEkleDTO
    {
        
        public string emekliSandikNo { get; set; }
        public string bagkurNo { get; set; }
        public string sandikKodu { get; set; }
        public string sicilNo { get; set; }
        public int sosyalGuvenlikKurumid { get; set; }
        public string referansAdSoyad { get; set; }
        public string oncekiIsyeri { get; set; }
        public int? oncekiCalismaSuresiAy { get; set; }
        public string oncekiIsAdres { get; set; }
    }
    public class PersonelDiğerBilgileriGuncelleDTO
    {
        public int personelid { get; set; }
        public int digerBilgilerid { get; set; }
        public string emekliSandikNo { get; set; }
        public string bagkurNo { get; set; }
        public string sandikKodu { get; set; }
        public string sicilNo { get; set; }
        public int sosyalGuvenlikKurumid { get; set; }
        public string referansAdSoyad { get; set; }
        public string oncekiIsyeri { get; set; }
        public int? oncekiCalismaSuresiAy { get; set; }
        public string oncekiIsAdres { get; set; }
        

    }
}
