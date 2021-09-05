using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("Tag", Schema = "Blog")]
    public partial class Tag
    {
        [Key]
        public long Id { get; set; }
        public long PostId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("Tag")]
        public virtual Post Post { get; set; }
    }
}
