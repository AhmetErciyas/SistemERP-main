using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("kullaniciYetkileri", Schema = "Ortak")]
    public partial class kullaniciYetkileri : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int kullaniciId { get; set; }
        public int yetkiId { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(kullaniciId))]
        [InverseProperty("kullaniciYetkileri")]
        public virtual kullanici kullanici { get; set; }
        [ForeignKey(nameof(yetkiId))]
        [InverseProperty(nameof(yetkiler.kullaniciYetkileri))]
        public virtual yetkiler yetki { get; set; }
    }
}
