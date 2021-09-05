using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("personelTabiKanun", Schema = "Personel")]
    public partial class personelTabiKanun : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int? personelid { get; set; }
        public int? personelKanunid { get; set; }
        public double? GVmuafiyet { get; set; }
        public double? UVSKisveren { get; set; }
        public double? GSSisveren { get; set; }
        public double? KVSKisveren { get; set; }
        public double? Issizlikisveren { get; set; }
        public double? DamgaVergisi { get; set; }
        public bool? GVHesaplansinMi { get; set; }
        public bool? SGKHesaplansinMi { get; set; }
        public bool? IssizlikHesaplansinMi { get; set; }
        public bool? DVHesaplansinMi { get; set; }
        public bool? GVMuafiyetiNeteEkle { get; set; }
        public double? UVSKisci { get; set; }
        public double? GSSisci { get; set; }
        public double? Issizlikisci { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
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
