using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelDiğerBilgileri
{
    public class PersonelDiğerBilgileriDAO
    {
        public string emekliSandikNo { get; set; }
        public string bagkurNo { get; set; }
        public string sandikKodu { get; set; }
        public string sicilNo { get; set; }
        public int    sosyalGuvenlikKurumid { get; set; }
        public string referansAdSoyad { get; set; }
        public string oncekiIsyeri { get; set; }
        public int?   oncekiCalismaSuresiAy { get; set; }
        public string oncekiIsAdres { get; set; }
    }
}
