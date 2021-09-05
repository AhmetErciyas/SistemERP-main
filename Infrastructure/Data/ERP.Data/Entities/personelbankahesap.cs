using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("personelBankaHesap", Schema = "Personel")]
    public partial class personelBankaHesap : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int personelid { get; set; }
        [StringLength(50)]
        public string kodu { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        public int? paraBirimiid { get; set; }
        [StringLength(150)]
        public string subeno { get; set; }
        [StringLength(150)]
        public string subeAdi { get; set; }
        [StringLength(150)]
        public string hesapNo { get; set; }
        [StringLength(150)]
        public string ibanNo { get; set; }
        public bool? anaHesap { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(personelid))]
        [InverseProperty("personelBankaHesap")]
        public virtual personel personel { get; set; }
    }
}
