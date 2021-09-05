using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("firmaAdres", Schema = "Firma")]
    public partial class firmaAdres : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int? firmaid { get; set; }
        public int? firmaAdresTurid { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        [StringLength(201)]
        public string adres1 { get; set; }
        [StringLength(201)]
        public string adres2 { get; set; }
        public int? postakoduid { get; set; }
        public int? ilceid { get; set; }
        public int? ilid { get; set; }
        public int? ulkeid { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(firmaid))]
        [InverseProperty("firmaAdres")]
        public virtual firma firma { get; set; }
        [ForeignKey(nameof(firmaAdresTurid))]
        [InverseProperty("firmaAdres")]
        public virtual firmaAdresTur firmaAdresTur { get; set; }
        [ForeignKey(nameof(ilid))]
        [InverseProperty("firmaAdres")]
        public virtual il il { get; set; }
        [ForeignKey(nameof(ilceid))]
        [InverseProperty("firmaAdres")]
        public virtual ilce ilce { get; set; }
        [ForeignKey(nameof(postakoduid))]
        [InverseProperty(nameof(postaKodu.firmaAdres))]
        public virtual postaKodu postakodu { get; set; }
        [ForeignKey(nameof(ulkeid))]
        [InverseProperty("firmaAdres")]
        public virtual ulke ulke { get; set; }
    }
}
