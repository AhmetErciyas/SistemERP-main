using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("bolum", Schema = "Firma")]
    public partial class bolum : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public bolum()
        {
            departman = new HashSet<departman>();
        }

        [Key]
        public int id { get; set; }
        public int firmaid { get; set; }
        [StringLength(50)]
        public string No { get; set; }
        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        [InverseProperty("bolum")]
        public virtual ICollection<departman> departman { get; set; }
    }
}
