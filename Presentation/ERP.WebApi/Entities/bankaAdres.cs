using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("bankaAdres", Schema = "Finans")]
    public partial class bankaAdres : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public short? bankaHesapid { get; set; }
        [StringLength(201)]
        public string adres1 { get; set; }
        [StringLength(201)]
        public string adres2 { get; set; }
        public short? postakoduid { get; set; }
        public short? ilceid { get; set; }
        public short? sehirid { get; set; }
        public short? ulkeid { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
    }
}
