using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("personelEmeklilik", Schema = "Personel")]
    public partial class personelEmeklilik : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int? personelid { get; set; }
        public int? ozelSigortaTurid { get; set; }
        public bool? bireyselEmeklilikVar { get; set; }
        public double? EmeklilikKesintiOran { get; set; }
        [StringLength(50)]
        public string policeNo { get; set; }
        public double? PTOemeklilik { get; set; }
        public double? PTOhayat { get; set; }
        public double? PTOsaglik { get; set; }
        public double? ITOemeklilik { get; set; }
        public double? ITOhayat { get; set; }
        public double? ITOsaglik { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
    }
}
