using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("firma", Schema = "Firma")]
    public partial class firma1 : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public firma1()
        {
            firmaIletisim = new HashSet<firmaIletisim>();
            organizasyon = new HashSet<organizasyon>();
            firmasube=new HashSet<sube>();
        }

        [Key]
        public int id { get; set; }
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
        [InverseProperty("sube")]
        public virtual ICollection<sube> firmasube { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<firmaIletisim> firmaIletisim { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<organizasyon> organizasyon { get; set; }
    }
}
