using ERP.Data.DAO.Kullanici;
using ERP.Domain.Core;

namespace ERP.Domain.Commands.Kullanici
{
    public class KullaniciGirisCommand : BaseCommand<KullaniciToken>
    {
        public KullaniciGirisCommand(string kullaniciAdi, string sifre,int firmaId)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            FirmaId = firmaId;
        }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int FirmaId { get; set; }
    }

    public class KullaniciEkleCommand : BaseCommand<KullaniciDAO>
    {
        public long KisiId { get; set; }
        public long PersonelId { get; set; }
        public long KullaniciGrupId { get; set; }
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }
    }

    public class KullaniciGuncelleCommand : BaseCommand<bool>
    {
        public ERP.Data.Entities.kullanici Kullanici { get; set; }
    }

    public class KullaniciSilCommand : BaseCommand<bool>
    {
        public int Id { get; set; }
    }

    public class KullaniciGetirQuery : BaseQuery<KullaniciDAO>
    {
        public long KullaniciId { get; set; }
    }
}
