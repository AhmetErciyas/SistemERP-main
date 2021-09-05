using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("paraBirimiTur", Schema = "Ortak")]
    public partial class paraBirimiTur : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        public int? TCMBindex { get; set; }
        public bool? aktifMi { get; set; }
    }
}
