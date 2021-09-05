using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("malzemeOzellikleri", Schema = "Stok")]
    public partial class malzemeOzellikleri : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int malzemeid { get; set; }
        public int birimid { get; set; }
        public int? islemTur { get; set; }
        public int? islemSayi { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal satisFiyat1 { get; set; }
        public bool satisFiyatKDV1 { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal indirimliFiyat { get; set; }
        public bool indirimliFiyatKDV { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal en { get; set; }
        public int? enBirim { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal boy { get; set; }
        public int? boyBirim { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal yukseklik { get; set; }
        public int? yukseklikBirim { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal alan { get; set; }
        public int? alanBirim { get; set; }
        public int? desi { get; set; }
        public bool? btobEkle { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(alanBirim))]
        [InverseProperty("malzemeOzelliklerialanBirimNavigation")]
        public virtual birim alanBirimNavigation { get; set; }
        [ForeignKey(nameof(birimid))]
        [InverseProperty("malzemeOzellikleribirim")]
        public virtual birim birim { get; set; }
        [ForeignKey(nameof(boyBirim))]
        [InverseProperty("malzemeOzellikleriboyBirimNavigation")]
        public virtual birim boyBirimNavigation { get; set; }
        [ForeignKey(nameof(enBirim))]
        [InverseProperty("malzemeOzelliklerienBirimNavigation")]
        public virtual birim enBirimNavigation { get; set; }
        [ForeignKey(nameof(islemTur))]
        [InverseProperty(nameof(malzemeIslemTur.malzemeOzellikleri))]
        public virtual malzemeIslemTur islemTurNavigation { get; set; }
        [ForeignKey(nameof(malzemeid))]
        [InverseProperty("malzemeOzellikleri")]
        public virtual malzeme malzeme { get; set; }
        [ForeignKey(nameof(yukseklikBirim))]
        [InverseProperty("malzemeOzellikleriyukseklikBirimNavigation")]
        public virtual birim yukseklikBirimNavigation { get; set; }
    }
}
