using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("personelBankaHesap", Schema = "Personel")]
    public partial class personelBankaHesap : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public personelBankaHesap()
        {
            personel = new HashSet<personel>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string kodu { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        public short? bankaid { get; set; }
        public short? bankaHesapTuruid { get; set; }
        public short? paraBirimiid { get; set; }
        [StringLength(50)]
        public string subeno { get; set; }
        [StringLength(50)]
        public string subeAdi { get; set; }
        [StringLength(50)]
        public string hesapNo { get; set; }
        [StringLength(50)]
        public string ibanNo { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [InverseProperty("personelBankaHesap")]
        public virtual ICollection<personel> personel { get; set; }
    }
}
