using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("malzeme", Schema = "Stok")]
    public partial class malzeme : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public malzeme()
        {
            malzemeOzellikleri = new HashSet<malzemeOzellikleri>();
            stokHareket = new HashSet<stokHareket>();
        }

        [Key]
        public int id { get; set; }
        public int? stokTurid { get; set; }
        [StringLength(200)]
        public string adi { get; set; }
        [StringLength(50)]
        public string kod { get; set; }
        [StringLength(50)]
        public string gizliKod { get; set; }
        [StringLength(250)]
        public string aciklama { get; set; }
        public int anabirim { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? stok { get; set; }
        [StringLength(200)]
        public string marka { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(anabirim))]
        [InverseProperty(nameof(birim.malzeme))]
        public virtual birim anabirimNavigation { get; set; }
        [ForeignKey(nameof(stokTurid))]
        [InverseProperty("malzeme")]
        public virtual stokTur stokTur { get; set; }
        [InverseProperty("malzeme")]
        public virtual ICollection<malzemeOzellikleri> malzemeOzellikleri { get; set; }
        [InverseProperty("malzeme")]
        public virtual ICollection<stokHareket> stokHareket { get; set; }
    }
}
