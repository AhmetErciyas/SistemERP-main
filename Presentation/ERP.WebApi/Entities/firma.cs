using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("firma", Schema = "Finans")]
    public partial class firma : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public firma()
        {
            InversefirmaNavigation = new HashSet<firma>();
            firmaAdres = new HashSet<firmaAdres>();
            firmaBanka = new HashSet<firmaBanka>();
            personel = new HashSet<personel>();
        }

        [Key]
        public int id { get; set; }
        public bool? firmaKurulus { get; set; }
        public int? firmaTurid { get; set; }
        public int? firmaYonid { get; set; }
        [StringLength(50)]
        public string kodu { get; set; }
        [StringLength(201)]
        public string adi { get; set; }
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
        [InverseProperty(nameof(firma.InversefirmaNavigation))]
        public virtual firma firmaNavigation { get; set; }
        [ForeignKey(nameof(firmaTurid))]
        [InverseProperty("firma")]
        public virtual firmaTur firmaTur { get; set; }
        [ForeignKey(nameof(firmaYonid))]
        [InverseProperty("firma")]
        public virtual firmaYon firmaYon { get; set; }
        [ForeignKey(nameof(nakliyeTurid))]
        [InverseProperty("firma")]
        public virtual nakliyeTur nakliyeTur { get; set; }
        [ForeignKey(nameof(odemePlanid))]
        [InverseProperty("firma")]
        public virtual odemePlan odemePlan { get; set; }
        [ForeignKey(nameof(paraBirimid))]
        [InverseProperty("firma")]
        public virtual paraBirim paraBirim { get; set; }
        [InverseProperty(nameof(firma.firmaNavigation))]
        public virtual ICollection<firma> InversefirmaNavigation { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<firmaAdres> firmaAdres { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<firmaBanka> firmaBanka { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<personel> personel { get; set; }
    }
}
