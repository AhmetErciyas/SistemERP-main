using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("Comment", Schema = "Blog")]
    public partial class Comment
    {
        [Key]
        public long Id { get; set; }
        public long PostId { get; set; }
        public long AuthorId { get; set; }
        [Required]
        [Column("Comment")]
        [StringLength(255)]
        public string Comment1 { get; set; }
        [Column(TypeName = "date")]
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Comment")]
        public virtual Author Author { get; set; }
        [ForeignKey(nameof(PostId))]
        [InverseProperty("Comment")]
        public virtual Post Post { get; set; }
    }
}
