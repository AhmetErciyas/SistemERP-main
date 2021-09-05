using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Entities
{
    [Table("sube", Schema = "Firma")]
    public partial class sube : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public sube()
        {
            
        }

        [Key]
        public int id { get; set; }
        public int firmaid { get; set; }
        [Required]
        [StringLength(100)]
        public string adi { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
        [ForeignKey(nameof(firmaid))]
        [InverseProperty(nameof(firma1.firmasube))]
        public virtual firma1 firma { get; set; }
       
    }
}