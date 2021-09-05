using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("recete", Schema = "Uretim")]
    public partial class recete : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public recete()
        {
            InverseanareceteNavigation = new HashSet<recete>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        [StringLength(250)]
        public string kodu { get; set; }
        public bool? durum { get; set; }
        [StringLength(250)]
        public string aciklama { get; set; }
        [StringLength(500)]
        public string not { get; set; }
        public int? rotaid { get; set; }
        public int? anarecete { get; set; }
        public int? firmaid { get; set; }

        [ForeignKey(nameof(anarecete))]
        [InverseProperty(nameof(recete.InverseanareceteNavigation))]
        public virtual recete anareceteNavigation { get; set; }
        [ForeignKey(nameof(rotaid))]
        [InverseProperty("recete")]
        public virtual rota rota { get; set; }
        [InverseProperty(nameof(recete.anareceteNavigation))]
        public virtual ICollection<recete> InverseanareceteNavigation { get; set; }
    }
}
