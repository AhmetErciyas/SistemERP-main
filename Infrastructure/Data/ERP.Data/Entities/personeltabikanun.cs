using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("personelTabiKanun", Schema = "Personel")]
    public partial class personelTabiKanun : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int personelid { get; set; }
        public int personelKanunid { get; set; }
        public bool? GVHesaplansinMi { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? GVmuafiyet { get; set; }
        public bool? GVMuafiyetiNeteEkle { get; set; }
        public bool? SGKHesaplansinMi { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? UVSKisveren { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? UVSKisci { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? GSSisveren { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? GSSisci { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? KVSKisveren { get; set; }
        public bool? IssizlikHesaplansinMi { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Issizlikisveren { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Issizlikisci { get; set; }
        public bool? DVHesaplansinMi { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? DamgaVergisi { get; set; }
        public bool? DVMuafiyetiNeteEkle { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public int? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public int? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(personelid))]
        [InverseProperty("personelTabiKanun")]
        public virtual personel personel { get; set; }
        [ForeignKey(nameof(personelKanunid))]
        [InverseProperty("personelTabiKanun")]
        public virtual personelKanun personelKanun { get; set; }
    }
}
