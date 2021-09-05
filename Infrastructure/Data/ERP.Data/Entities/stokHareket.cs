using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("stokHareket", Schema = "Stok")]
    public partial class stokHareket : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int malzemeid { get; set; }
        [StringLength(250)]
        public string aciklama { get; set; }
        public int? stokHareketTurid { get; set; }
        public int? referansid { get; set; }
        public int? depoid { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? gelen { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? giden { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? islemTarih { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(depoid))]
        [InverseProperty("stokHareket")]
        public virtual depo depo { get; set; }
        [ForeignKey(nameof(malzemeid))]
        [InverseProperty("stokHareket")]
        public virtual malzeme malzeme { get; set; }
        [ForeignKey(nameof(stokHareketTurid))]
        [InverseProperty("stokHareket")]
        public virtual stokHareketTur stokHareketTur { get; set; }
    }
}
