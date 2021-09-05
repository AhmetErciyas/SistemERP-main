using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("ekGelirGider", Schema = "Personel")]
    public partial class ekGelirGider : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int? ekGelirGiderTurid { get; set; }
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

        [ForeignKey(nameof(ekGelirGiderTurid))]
        [InverseProperty("ekGelirGider")]
        public virtual ekGelirGiderTur ekGelirGiderTur { get; set; }
        [ForeignKey(nameof(sosyalGuvenlikKurumid))]
        [InverseProperty("ekGelirGider")]
        public virtual sosyalGuvenlikKurum sosyalGuvenlikKurum { get; set; }
    }
}
