using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("paraBirim", Schema = "Ortak")]
    public partial class paraBirim : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public paraBirim()
        {
            firma = new HashSet<firma>();
            personelMaas = new HashSet<personelMaas>();
        }

        [Key]
        public int id { get; set; }
        public short? No { get; set; }
        [StringLength(6)]
        public string kodu { get; set; }
        [Required]
        [StringLength(31)]
        public string adi { get; set; }
        [StringLength(11)]
        public string evrenselAdi { get; set; }

        [InverseProperty("paraBirim")]
        public virtual ICollection<firma> firma { get; set; }
        [InverseProperty("maasParaBirim")]
        public virtual ICollection<personelMaas> personelMaas { get; set; }
    }
}
