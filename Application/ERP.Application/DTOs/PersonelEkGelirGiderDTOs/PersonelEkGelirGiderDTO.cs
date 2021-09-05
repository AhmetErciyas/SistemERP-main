using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.PersonelEkGelirGiderDTOs
{
    public class PersonelEkGelirGiderDTO
    {

        public int personelid { get; set; }
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
    public class PersonelEkGelirGiderEkleDTO
    {
        
       
        public int? ekGelirGiderTur { get; set; }
        public int? ekGelirGiderAciklama { get; set; }
        public bool? ucretlendirmeTur { get; set; }
        public decimal? birim { get; set; }
        public decimal? tutar { get; set; }
        public bool? netMi { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
    }

    public class PersonelEkGelirGiderGuncelleDTO
    {
       
        public int personelid { get; set; }
        public int? ekGelirGiderTur { get; set; }
        public int? ekGelirGiderAciklama { get; set; }
        public bool? ucretlendirmeTur { get; set; }
        public decimal? birim { get; set; }
        public decimal? tutar { get; set; }
        public bool? netMi { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        

    }
}
