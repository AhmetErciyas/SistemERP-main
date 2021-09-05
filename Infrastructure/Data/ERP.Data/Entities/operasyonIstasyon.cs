﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("operasyonIstasyon", Schema = "Uretim")]
    public partial class operasyonIstasyon : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int? operasyonid { get; set; }
        public int? istasyonid { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? kullanimSuresi { get; set; }
        public short? kullanimSuresiZaman { get; set; }
        public bool? iptalmi { get; set; }
        public bool? silindimi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kayitTarih { get; set; }
        public long? kayitEdenid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? degistirmeTarih { get; set; }
        public long? degistirenid { get; set; }

        [ForeignKey(nameof(istasyonid))]
        [InverseProperty("operasyonIstasyon")]
        public virtual istasyon istasyon { get; set; }
        [ForeignKey(nameof(operasyonid))]
        [InverseProperty("operasyonIstasyon")]
        public virtual operasyon operasyon { get; set; }
    }
}
