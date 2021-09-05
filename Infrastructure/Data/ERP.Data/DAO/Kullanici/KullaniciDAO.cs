using ERP.Data.DAO.Organizasyon;
using System;
using System.Collections.Generic;

namespace ERP.Data.DAO.Kullanici
{
    public class KullaniciDAO
    {
        public long Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string AdSoyad
        {
            get
            {
                return string.Format("{0} {1}", Ad, Soyad);
            }
        }

        public string TCKimlikNo { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public int SehirId { get; set; }
        public List<KademeDAO> Gorevler { get; set; }
    }


    public class KullaniciToken
    {
        public long Id { get; set; }
        public string TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdSoyad
        {
            get
            {
                return string.Format("{0} {1}", Ad, Soyad);
            }
        }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public int KullaniciFirmaRolId { get; set; }
        public int RolId { get; set; }
        public string RolAd { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; }
        public int SubeId { get; set; }
        public string SubeAd { get; set; }
        public string FirmaBayiBelgeNo { get; set; }
        public int? FirmaTesisId { get; set; }
        public string FirmaTesisAd { get; set; }
        public int SehirId { get; set; }
        public List<KademeDAO> Gorevler { get; set; }
    }
}
