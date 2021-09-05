using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("organizasyon", Schema = "Firma")]
    public partial class organizasyon : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public organizasyon()
        {
            organizasyonSatir = new HashSet<organizasyonSatir>();
        }

        [Key]
        public int id { get; set; }
        public int firmaid { get; set; }
        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        [ForeignKey(nameof(firmaid))]
        [InverseProperty(nameof(firma1.organizasyon))]
        public virtual firma1 firma { get; set; }
        [InverseProperty("organizasyon")]
        public virtual ICollection<organizasyonSatir> organizasyonSatir { get; set; }
    }
}
