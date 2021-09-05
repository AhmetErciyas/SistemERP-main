using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("personelDepartman", Schema = "Personel")]
    public partial class personelDepartman : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int personelid { get; set; }
        public int departmanid { get; set; }
        public bool? yoneticiMi { get; set; }
        public bool? vekilMi { get; set; }
        public bool? silindimi { get; set; }

        [ForeignKey(nameof(departmanid))]
        [InverseProperty("personelDepartman")]
        public virtual departman departman { get; set; }
        [ForeignKey(nameof(personelid))]
        [InverseProperty("personelDepartman")]
        public virtual personel personel { get; set; }
    }
}
