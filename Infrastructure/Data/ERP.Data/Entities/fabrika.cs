using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("fabrika", Schema = "Firma")]
    public partial class fabrika : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int firmaid { get; set; }
        [StringLength(50)]
        public string No { get; set; }
        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        [ForeignKey(nameof(firmaid))]
        [InverseProperty("fabrika")]
        public virtual firma firma { get; set; }
    }
}
