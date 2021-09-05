using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("departman", Schema = "Firma")]
    public partial class departman : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public departman()
        {
            personel = new HashSet<personel>();
            personelDepartman = new HashSet<personelDepartman>();
        }

        [Key]
        public int id { get; set; }
        public int? bolumid { get; set; }
        [StringLength(50)]
        public string No { get; set; }
        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        [ForeignKey(nameof(bolumid))]
        [InverseProperty("departman")]
        public virtual bolum bolum { get; set; }
        [InverseProperty("departman")]
        public virtual ICollection<personel> personel { get; set; }
        [InverseProperty("departman")]
        public virtual ICollection<personelDepartman> personelDepartman { get; set; }
    }
}
