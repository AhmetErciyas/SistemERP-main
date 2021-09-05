using ERP.Application.DTOs.PersonelDTOs;

namespace ERP.Application.DTOs.KullaniciDTOs
{
    public class KullaniciDTO
    {
        public long Id { get; set; }
        public long KisiId { get; set; }
        public long PersonelId { get; set; }
        public long KullaniciGrupId { get; set; }
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }

    }

    public class KullaniciEkleDTO
    {
        public long Id { get; set; }
        public long KisiId { get; set; }
        public long PersonelId { get; set; }
        public long KullaniciGrupId { get; set; }
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }

    }
}
