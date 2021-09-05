using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("ekGelirGider", Schema = "Personel")]
    public partial class ekGelirGider : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int personelid { get; set; }
        public int? ekGelirGiderTur { get; set; }
        public int? ekGelirGiderAciklama { get; set; }
        public bool? ucretlendirmeTur { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? birim { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? tutar { get; set; }
        public bool? netMi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaslangicTarih { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BitisTarih { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(ekGelirGiderAciklama))]
        [InverseProperty("ekGelirGider")]
        public virtual ekGelirGiderAciklama ekGelirGiderAciklamaNavigation { get; set; }
        [ForeignKey(nameof(ekGelirGiderTur))]
        [InverseProperty("ekGelirGider")]
        public virtual ekGelirGiderTur ekGelirGiderTurNavigation { get; set; }
        [ForeignKey(nameof(personelid))]
        [InverseProperty("ekGelirGider")]
        public virtual personel personel { get; set; }
    }
}
