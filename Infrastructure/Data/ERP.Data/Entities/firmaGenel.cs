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
    public partial class firmaGenel
    {
        public firmaGenel()
        {
            firmailetisim = new HashSet<firmaIletisim>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitedenid { get; set; }
        [Column(TypeName = "timestamp(3) without time zone")]
        public DateTime? kayittarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "timestamp(3) without time zone")]
        public DateTime? degistirmetarih { get; set; }

        [InverseProperty("firma")]
        public virtual ICollection<firmaIletisim> firmailetisim { get; set; }
    }
}
