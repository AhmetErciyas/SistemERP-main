using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("digerBilgiler", Schema = "Personel")]
    public partial class digerBilgiler : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int personelid { get; set; }
        [StringLength(50)]
        public string emekliSandikNo { get; set; }
        [StringLength(50)]
        public string bagkurNo { get; set; }
        [StringLength(50)]
        public string sandikKodu { get; set; }
        [StringLength(50)]
        public string sicilNo { get; set; }
        public int sosyalGuvenlikKurumid { get; set; }
        [StringLength(150)]
        public string referansAdSoyad { get; set; }
        [StringLength(150)]
        public string oncekiIsyeri { get; set; }
        public int? oncekiCalismaSuresiAy { get; set; }
        [StringLength(250)]
        public string oncekiIsAdres { get; set; }
        public bool? silindimi { get; set; }

        [ForeignKey(nameof(personelid))]
        [InverseProperty("digerBilgiler")]
        public virtual personel personel { get; set; }
        [ForeignKey(nameof(sosyalGuvenlikKurumid))]
        [InverseProperty("digerBilgiler")]
        public virtual sosyalGuvenlikKurum sosyalGuvenlikKurum { get; set; }
    }
}
