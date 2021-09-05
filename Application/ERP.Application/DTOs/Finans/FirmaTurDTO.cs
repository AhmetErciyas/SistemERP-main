using System;

namespace ERP.Application.DTOs.Finans
{
    public class FirmaTurDTO
    {
        public int id { get; set; }
        public string adi { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public DateTime? kayitTarih { get; set; }
        public long? kayitEdenid { get; set; }
        public DateTime? degistirmeTarih { get; set; }
        public long? degistirenid { get; set; }
    }
}
