using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("ulke", Schema = "Ortak")]
    public partial class ulke : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public ulke()
        {
            firmaAdres = new HashSet<firmaAdres>();
            personelKimlikulke = new HashSet<personelKimlik>();
            personelKimlikuyruk = new HashSet<personelKimlik>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string kodu { get; set; }
        [Required]
        [StringLength(250)]
        public string adi { get; set; }

        [InverseProperty("ulke")]
        public virtual ICollection<firmaAdres> firmaAdres { get; set; }
        [InverseProperty(nameof(personelKimlik.ulke))]
        public virtual ICollection<personelKimlik> personelKimlikulke { get; set; }
        [InverseProperty(nameof(personelKimlik.uyruk))]
        public virtual ICollection<personelKimlik> personelKimlikuyruk { get; set; }
    }
}
