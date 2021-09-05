using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("il", Schema = "Ortak")]
    public partial class il : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public il()
        {
            firmaAdres = new HashSet<firmaAdres>();
            personelKimlik = new HashSet<personelKimlik>();
        }

        [Key]
        public int id { get; set; }
        public int ulkeid { get; set; }
        [StringLength(50)]
        public string kodu { get; set; }
        [Required]
        [StringLength(250)]
        public string adi { get; set; }
        [StringLength(5)]
        public string telKodu { get; set; }

        [InverseProperty("il")]
        public virtual ICollection<firmaAdres> firmaAdres { get; set; }
        [InverseProperty("il")]
        public virtual ICollection<personelKimlik> personelKimlik { get; set; }
    }
}
