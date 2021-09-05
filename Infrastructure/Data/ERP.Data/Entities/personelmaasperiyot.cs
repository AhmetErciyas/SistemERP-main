﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("personelMaasPeriyot", Schema = "Personel")]
    public partial class personelMaasPeriyot : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public personelMaasPeriyot()
        {
            personelMaas = new HashSet<personelMaas>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(20)]
        public string adi { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? degistirenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }

        [InverseProperty("personelMaasPeriyot")]
        public virtual ICollection<personelMaas> personelMaas { get; set; }
    }
}
