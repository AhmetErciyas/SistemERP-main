using System;

namespace ERP.Application.DTOs.PersonelDTOs
{
    public class KisiDTO
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
        public string Mail { get; set; }
        public short DurumId { get; set; }
        public string DurumAd { get; set; }
        public short? CinsiyetId { get; set; }
        public string CinsiyetAd { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string TCKN { get; set; }
        public short? KanGrupId { get; set; }
        public string KanGrupAd { get; set; }
        public short? MedeniHalId { get; set; }
        public string MedeniHalAd { get; set; }
        public string IBANHesapNo { get; set; }
    }
}
