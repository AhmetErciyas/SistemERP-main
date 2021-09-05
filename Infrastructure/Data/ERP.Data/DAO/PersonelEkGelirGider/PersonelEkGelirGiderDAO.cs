using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelEkGelirGider
{
    public class PersonelEkGelirGiderDAO
    {
        public int? ekGelirGiderTur { get; set; }
        public string ekGelirGiderTurAdi { get; set; }
        public string ekGelirGiderAciklamaAdi { get; set; }
        public int? ekGelirGiderAciklama { get; set; }
        public bool? ucretlendirmeTur { get; set; }
        public decimal? birim { get; set; }
        public decimal? tutar { get; set; }
        public bool? netMi { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
    }
}
