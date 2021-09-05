using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("paketlemeKod", Schema = "Ortak")]
    public partial class paketlemeKod : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        [StringLength(13)]
        public string kod { get; set; }
        [StringLength(51)]
        public string ad { get; set; }
        [StringLength(13)]
        public string evrenselkod { get; set; }
    }
}
