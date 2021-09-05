﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("istasyonUretim", Schema = "Uretim")]
    public partial class istasyonUretim : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public istasyonUretim()
        {
            operasyonIstasyonUretim = new HashSet<operasyonIstasyonUretim>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string kod { get; set; }
        [StringLength(150)]
        public string adi { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? gunlukCalismaSaat { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
        public long? degistirenid { get; set; }

        [InverseProperty("istasyonUretim")]
        public virtual ICollection<operasyonIstasyonUretim> operasyonIstasyonUretim { get; set; }
    }
}
