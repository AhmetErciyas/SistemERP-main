using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("ekGelirGiderAciklama", Schema = "Personel")]
    public partial class ekGelirGiderAciklama : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public ekGelirGiderAciklama()
        {
            ekGelirGider = new HashSet<ekGelirGider>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(20)]
        public string kod { get; set; }
        [StringLength(20)]
        public string adi { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
        public bool? ucretlendirmeTur { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? tutar { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? birim { get; set; }
        public bool? netMi { get; set; }
        public bool? GVMuaf { get; set; }
        public bool? sigortaMuaf { get; set; }
        public bool? DVMuaf { get; set; }
        public bool? Primikramiye { get; set; }

        [InverseProperty("ekGelirGiderAciklamaNavigation")]
        public virtual ICollection<ekGelirGider> ekGelirGider { get; set; }
    }
}
