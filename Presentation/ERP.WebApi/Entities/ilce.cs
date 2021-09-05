using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("ilce", Schema = "Ortak")]
    public partial class ilce : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public ilce()
        {
            firmaAdres = new HashSet<firmaAdres>();
            personelKimlik = new HashSet<personelKimlik>();
        }

        [Key]
        public int id { get; set; }
        public int ilid { get; set; }
        [StringLength(50)]
        public string No { get; set; }
        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        [InverseProperty("ilce")]
        public virtual ICollection<firmaAdres> firmaAdres { get; set; }
        [InverseProperty("ilce")]
        public virtual ICollection<personelKimlik> personelKimlik { get; set; }
    }
}
