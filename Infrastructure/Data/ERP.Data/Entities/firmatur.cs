using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("firmaTur", Schema = "Finans")]
    public partial class firmaTur : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public firmaTur()
        {
            cariKart = new HashSet<cariKart>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string adi { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
        public long? degistirenid { get; set; }

        [InverseProperty("firmaTur")]
        public virtual ICollection<cariKart> cariKart { get; set; }
    }
}
