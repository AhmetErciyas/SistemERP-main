using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("firmaIletisim", Schema = "Firma")]
    public partial class firmaIletisim : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int? firmaid { get; set; }
        public int? firmaIletisimTurid { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(firmaid))]
        [InverseProperty(nameof(firma1.firmaIletisim))]
        public virtual firma1 firma { get; set; }
        [ForeignKey(nameof(firmaIletisimTurid))]
        [InverseProperty("firmaIletisim")]
        public virtual firmaIletisimTur firmaIletisimTur { get; set; }
    }
}
