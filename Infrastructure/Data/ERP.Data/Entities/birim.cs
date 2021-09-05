using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("birim", Schema = "Stok")]
    public partial class birim : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public birim()
        {
            malzeme = new HashSet<malzeme>();
            malzemeOzelliklerialanBirimNavigation = new HashSet<malzemeOzellikleri>();
            malzemeOzellikleribirim = new HashSet<malzemeOzellikleri>();
            malzemeOzellikleriboyBirimNavigation = new HashSet<malzemeOzellikleri>();
            malzemeOzelliklerienBirimNavigation = new HashSet<malzemeOzellikleri>();
            malzemeOzellikleriyukseklikBirimNavigation = new HashSet<malzemeOzellikleri>();
        }

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(150)]
        public string adi { get; set; }
        [StringLength(250)]
        public string aciklama { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
        public int? tur { get; set; }

        [InverseProperty("anabirimNavigation")]
        public virtual ICollection<malzeme> malzeme { get; set; }
        [InverseProperty(nameof(malzemeOzellikleri.alanBirimNavigation))]
        public virtual ICollection<malzemeOzellikleri> malzemeOzelliklerialanBirimNavigation { get; set; }
        [InverseProperty(nameof(malzemeOzellikleri.birim))]
        public virtual ICollection<malzemeOzellikleri> malzemeOzellikleribirim { get; set; }
        [InverseProperty(nameof(malzemeOzellikleri.boyBirimNavigation))]
        public virtual ICollection<malzemeOzellikleri> malzemeOzellikleriboyBirimNavigation { get; set; }
        [InverseProperty(nameof(malzemeOzellikleri.enBirimNavigation))]
        public virtual ICollection<malzemeOzellikleri> malzemeOzelliklerienBirimNavigation { get; set; }
        [InverseProperty(nameof(malzemeOzellikleri.yukseklikBirimNavigation))]
        public virtual ICollection<malzemeOzellikleri> malzemeOzellikleriyukseklikBirimNavigation { get; set; }
    }
}
