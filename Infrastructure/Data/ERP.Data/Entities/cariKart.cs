using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("cariKart", Schema = "Finans")]
    public partial class cariKart : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public cariKart()
        {
            Inversefirma = new HashSet<cariKart>();
            bankaHesap = new HashSet<bankaHesap>();
            firmaAdres = new HashSet<firmaAdres>();
        }

        [Key]
        public int id { get; set; }
        public bool? firmaKurulus { get; set; }
        public int? firmaTurid { get; set; }
        public int? firmaYonid { get; set; }
        [StringLength(50)]
        public string kodu { get; set; }
        [StringLength(201)]
        public string unvan { get; set; }
        [StringLength(16)]
        public string vergiNo { get; set; }
        [StringLength(31)]
        public string vergiDaire { get; set; }
        public int? ilgiliid { get; set; }
        public int? odemePlanid { get; set; }
        public bool? yurtIciFirmaMi { get; set; }
        public int? eIrsaliyeTurid { get; set; }
        public int? eFaturaTurid { get; set; }
        [StringLength(201)]
        public string eFaturaAdres { get; set; }
        public int? nakliyeTurid { get; set; }
        public int? firmaid { get; set; }
        public int? paraBirimid { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(firmaid))]
        [InverseProperty(nameof(cariKart.Inversefirma))]
        public virtual cariKart firma { get; set; }
        [ForeignKey(nameof(firmaTurid))]
        [InverseProperty("cariKart")]
        public virtual firmaTur firmaTur { get; set; }
        [ForeignKey(nameof(firmaYonid))]
        [InverseProperty("cariKart")]
        public virtual firmaYon firmaYon { get; set; }
        [ForeignKey(nameof(nakliyeTurid))]
        [InverseProperty("cariKart")]
        public virtual nakliyeTur nakliyeTur { get; set; }
        [ForeignKey(nameof(odemePlanid))]
        [InverseProperty("cariKart")]
        public virtual odemePlan odemePlan { get; set; }
        [ForeignKey(nameof(paraBirimid))]
        [InverseProperty("cariKart")]
        public virtual paraBirim paraBirim { get; set; }
        [InverseProperty(nameof(cariKart.firma))]
        public virtual ICollection<cariKart> Inversefirma { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<bankaHesap> bankaHesap { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<firmaAdres> firmaAdres { get; set; }
    }
}
