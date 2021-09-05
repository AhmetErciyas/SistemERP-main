using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("Post", Schema = "Blog")]
    public partial class Post
    {
        public Post()
        {
            Comment = new HashSet<Comment>();
            Tag = new HashSet<Tag>();
        }

        [Key]
        public long Id { get; set; }
        public long AuthorId { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Column(TypeName = "date")]
        public DateTime PostDate { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Post")]
        public virtual Author Author { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
