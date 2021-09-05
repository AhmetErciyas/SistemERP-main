using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("organizasyonSatir", Schema = "Firma")]
    public partial class organizasyonSatir : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int organizasyonid { get; set; }
        [Required]
        [StringLength(100)]
        public string adi { get; set; }
        public short? parentid { get; set; }

        [ForeignKey(nameof(organizasyonid))]
        [InverseProperty("organizasyonSatir")]
        public virtual organizasyon organizasyon { get; set; }
    }
}
