using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("personelMaas", Schema = "Personel")]
    public partial class personelMaas : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public personelMaas()
        {
            personel = new HashSet<personel>();
        }

        [Key]
        public int id { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? maas { get; set; }
        public int? maasParaBirimid { get; set; }
        public bool? maasbrut { get; set; }
        public bool? asgariUcret { get; set; }
        public int? personelMaasOdemeTurid { get; set; }
        public int? personelMaasPeriyotid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? baslangicTarih { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? bitisTarih { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [ForeignKey(nameof(maasParaBirimid))]
        [InverseProperty(nameof(paraBirim.personelMaas))]
        public virtual paraBirim maasParaBirim { get; set; }
        [ForeignKey(nameof(personelMaasOdemeTurid))]
        [InverseProperty("personelMaas")]
        public virtual personelMaasOdemeTur personelMaasOdemeTur { get; set; }
        [ForeignKey(nameof(personelMaasPeriyotid))]
        [InverseProperty("personelMaas")]
        public virtual personelMaasPeriyot personelMaasPeriyot { get; set; }
        [InverseProperty("personelMaas")]
        public virtual ICollection<personel> personel { get; set; }
    }
}
