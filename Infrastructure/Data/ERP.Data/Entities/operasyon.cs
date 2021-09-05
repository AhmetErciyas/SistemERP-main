using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("operasyon", Schema = "Uretim")]
    public partial class operasyon : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public operasyon()
        {
            operasyonIstasyon = new HashSet<operasyonIstasyon>();
            operasyonIstasyonUretim = new HashSet<operasyonIstasyonUretim>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string kod { get; set; }
        [StringLength(150)]
        public string adi { get; set; }
        [StringLength(500)]
        public string aciklama { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
        public long? degistirenid { get; set; }

        [InverseProperty("operasyon")]
        public virtual ICollection<operasyonIstasyon> operasyonIstasyon { get; set; }
        [InverseProperty("operasyon")]
        public virtual ICollection<operasyonIstasyonUretim> operasyonIstasyonUretim { get; set; }
    }
}
