using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("yetkiGruplariDetay", Schema = "Ortak")]
    public partial class yetkiGruplariDetay : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int yetkiId { get; set; }
        public int grupId { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(grupId))]
        [InverseProperty(nameof(yetkiGruplari.yetkiGruplariDetay))]
        public virtual yetkiGruplari grup { get; set; }
        [ForeignKey(nameof(yetkiId))]
        [InverseProperty(nameof(yetkiler.yetkiGruplariDetay))]
        public virtual yetkiler yetki { get; set; }
    }
}
