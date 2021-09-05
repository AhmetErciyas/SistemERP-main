using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("vergiDaire", Schema = "Ortak")]
    public partial class vergiDaire : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public vergiDaire()
        {
            personel = new HashSet<personel>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(25)]
        public string kod { get; set; }
        [StringLength(51)]
        public string ad { get; set; }
        public int? sehirid { get; set; }

        [InverseProperty("vergiDaire")]
        public virtual ICollection<personel> personel { get; set; }
    }
}
