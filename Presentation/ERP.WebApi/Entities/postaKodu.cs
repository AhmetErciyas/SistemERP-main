using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("postaKodu", Schema = "Ortak")]
    public partial class postaKodu : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public postaKodu()
        {
            firmaAdres = new HashSet<firmaAdres>();
        }

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(250)]
        public string adi { get; set; }
        public short ilceid { get; set; }
        [Column("postaKodu")]
        [StringLength(50)]
        public string postaKodu1 { get; set; }

        [InverseProperty("postakodu")]
        public virtual ICollection<firmaAdres> firmaAdres { get; set; }
    }
}
