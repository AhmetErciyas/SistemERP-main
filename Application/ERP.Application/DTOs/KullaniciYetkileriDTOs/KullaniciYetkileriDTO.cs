using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.KullaniciYetkileriDTOs
{
   
    public class KullaniciYetkiDTO
    {
        public int id { get; set; }
        public int kullaniciId { get; set; }
        public int yetkiId { get; set; }
        public string yetkiAdi { get; set; }
        public string kulaniciAdi { get; set; }
    }
    public class KullaniciYetkiEkleDTO
    {
        public int kullaniciId { get; set; }
        public int yetkiId { get; set; }
    }
    public class KullaniciYetkiGuncelleDTO
    {
        public int Id { get; set; }
        public int kullaniciId { get; set; }
        public int yetkiId { get; set; }
    }
}
