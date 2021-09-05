using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("genelOzellikler", Schema = "Stok")]
    public partial class genelOzellikler : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? minSiparisMiktari { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? asgariMiktar { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? azamiMiktar { get; set; }
        public bool? riskKontrol { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? riskMiktari { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? rafOmru { get; set; }
        [StringLength(50)]
        public string rafYeri { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? alisKDV { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? satisKDV { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? toptanSatisKDV { get; set; }
        public int? tevkifatKodu { get; set; }
        [StringLength(20)]
        public string tevkifatOrani { get; set; }
        [StringLength(250)]
        public string kareBarkod { get; set; }
        [StringLength(250)]
        public string globalBarkod { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? tedarikSuresi { get; set; }
        public int? tedarikSuresiPeriyot { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? garantiSuresi { get; set; }
        public int? garantiSuresiPeriyot { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(tevkifatKodu))]
        [InverseProperty("genelOzellikler")]
        public virtual tevkifatKodu tevkifatKoduNavigation { get; set; }
    }
}
