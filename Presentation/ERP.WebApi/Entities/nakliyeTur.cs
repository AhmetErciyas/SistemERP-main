using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("nakliyeTur", Schema = "Ortak")]
    public partial class nakliyeTur : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public nakliyeTur()
        {
            firma = new HashSet<firma>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(13)]
        public string kod { get; set; }
        [StringLength(51)]
        public string adi { get; set; }
        [StringLength(13)]
        public string evrenselkod { get; set; }

        [InverseProperty("nakliyeTur")]
        public virtual ICollection<firma> firma { get; set; }
    }
}
