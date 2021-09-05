using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("firma", Schema = "Firma")]
    public partial class firma1 : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public firma1()
        {
            bolum = new HashSet<bolum>();
            depo = new HashSet<depo>();
            fabrika = new HashSet<fabrika>();
            firmaIletisim = new HashSet<firmaIletisim>();
            organizasyon = new HashSet<organizasyon>();
            personel = new HashSet<personel>();
            sube = new HashSet<sube>();
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

        [InverseProperty("firma")]
        public virtual ICollection<bolum> bolum { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<depo> depo { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<fabrika> fabrika { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<firmaIletisim> firmaIletisim { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<organizasyon> organizasyon { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<personel> personel { get; set; }
        [InverseProperty("firma")]
        public virtual ICollection<sube> sube { get; set; }
    }
}
