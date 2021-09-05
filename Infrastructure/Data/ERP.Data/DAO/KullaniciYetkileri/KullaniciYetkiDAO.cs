using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.KullaniciYetkileri
{
    public class KullaniciYetkiDAO
    {
        public int id { get; set; }
        public int kullaniciId { get; set; }
        public int yetkiId { get; set; }
        public string yetkiAdi { get; set; }
        public string kulaniciAdi { get; set; }
    }
}
