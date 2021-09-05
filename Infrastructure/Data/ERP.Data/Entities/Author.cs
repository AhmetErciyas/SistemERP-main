using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("Author", Schema = "Blog")]
    public partial class Author
    {
        public Author()
        {
            Comment = new HashSet<Comment>();
            Post = new HashSet<Post>();
        }

        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Surname { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        public bool Status { get; set; }

        [InverseProperty("Author")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("Author")]
        public virtual ICollection<Post> Post { get; set; }
    }
}
