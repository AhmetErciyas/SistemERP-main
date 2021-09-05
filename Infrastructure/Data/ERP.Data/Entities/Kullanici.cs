using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("kullanici", Schema = "Kullanici")]
    public partial class kullanici : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public kullanici()
        {
            kullaniciYetkileri = new HashSet<kullaniciYetkileri>();
        }

        [Key]
        public int id { get; set; }
        public int grupid { get; set; }
        public int personelId { get; set; }
        [Required]
        [StringLength(250)]
        public string kullaniciAdi { get; set; }
        [Required]
        [StringLength(250)]
        public string sifre { get; set; }
        public bool? aktifMi { get; set; }
        [StringLength(250)]
        public string email { get; set; }
        [StringLength(50)]
        public string GSMno { get; set; }

        [ForeignKey(nameof(personelId))]
        [InverseProperty("kullanici")]
        public virtual personel personel { get; set; }
        [InverseProperty("kullanici")]
        public virtual ICollection<kullaniciYetkileri> kullaniciYetkileri { get; set; }
    }
}
