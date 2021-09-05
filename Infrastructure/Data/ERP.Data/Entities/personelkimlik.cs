using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("personelKimlik", Schema = "Personel")]
    public partial class personelKimlik : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int personelid { get; set; }
        public int kimlikTurid { get; set; }
        public int? medeniHal { get; set; }
        public bool? cinsiyet { get; set; }
        [StringLength(20)]
        public string seriNo { get; set; }
        [StringLength(20)]
        public string tckNo { get; set; }
        public int? kanGrup { get; set; }
        [StringLength(50)]
        public string babaAdi { get; set; }
        [StringLength(50)]
        public string anneAdi { get; set; }
        [StringLength(50)]
        public string dogumYeri { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dogumTarih { get; set; }
        public int? ulkeid { get; set; }
        public int? ilid { get; set; }
        public int? ilceid { get; set; }
        public int? mahalleid { get; set; }
        [StringLength(20)]
        public string hesKodu { get; set; }
        public bool? ehliyetVarMi { get; set; }
        public int? uyrukid { get; set; }
        [StringLength(50)]
        public string oncekiSoyadi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? verilisTarih { get; set; }
        [StringLength(50)]
        public string verildigiYer { get; set; }
        [StringLength(50)]
        public string verilisNedeni { get; set; }
        [StringLength(50)]
        public string siraNo { get; set; }
        [StringLength(50)]
        public string ciltNo { get; set; }
        [StringLength(50)]
        public string aileSiraNo { get; set; }
        [StringLength(50)]
        public string kayitNo { get; set; }
        [StringLength(150)]
        public string eposta { get; set; }
        public bool? silindimi { get; set; }

        [ForeignKey(nameof(ilid))]
        [InverseProperty("personelKimlik")]
        public virtual il il { get; set; }
        [ForeignKey(nameof(ilceid))]
        [InverseProperty("personelKimlik")]
        public virtual ilce ilce { get; set; }
        [ForeignKey(nameof(kimlikTurid))]
        [InverseProperty("personelKimlik")]
        public virtual kimlikTur kimlikTur { get; set; }
        [ForeignKey(nameof(personelid))]
        [InverseProperty("personelKimlik")]
        public virtual personel personel { get; set; }
        [ForeignKey(nameof(ulkeid))]
        [InverseProperty("personelKimlikulke")]
        public virtual ulke ulke { get; set; }
        [ForeignKey(nameof(uyrukid))]
        [InverseProperty("personelKimlikuyruk")]
        public virtual ulke uyruk { get; set; }
    }
}
