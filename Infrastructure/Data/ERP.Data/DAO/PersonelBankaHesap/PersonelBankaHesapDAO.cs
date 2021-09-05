using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelBankaHesap
{
    public class PersonelBankaHesapDAO
    {
        public int?   personelid { get; set; }
        public string kodu { get; set; }
        public string adi { get; set; }
        public int?   paraBirimiid { get; set; }
        public string paraBirimAdi { get; set; }
        public string subeno { get; set; }
        public string subeAdi { get; set; }
        public string hesapNo { get; set; }
        public string ibanNo { get; set; }
        public bool?  anaHesap { get; set; }
    }
}
