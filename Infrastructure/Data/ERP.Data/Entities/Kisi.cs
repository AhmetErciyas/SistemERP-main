using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ERP.Data.Entities
{
    [Table("Kisi", Schema = "Kullanici")]
    public partial class Kisi : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public Kisi()
        {
            Personel = new HashSet<personel>();
        }

        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Ad { get; set; }
        [Required]
        [StringLength(100)]
        public string Soyad { get; set; }
        [StringLength(150)]
        public string Mail { get; set; }
        public short DurumId { get; set; }
        public short? CinsiyetId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }
        [StringLength(11)]
        public string TCKN { get; set; }
        public short? KanGrupId { get; set; }
        public short? MedeniHalId { get; set; }
        [StringLength(50)]
        public string IBANHesapNo { get; set; }

        [InverseProperty("Kisi")]
        public virtual ICollection<personel> Personel { get; set; }
    }
}
