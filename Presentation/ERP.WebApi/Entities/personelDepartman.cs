using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
{
    [Table("personelDepartman", Schema = "Personel")]
    public partial class personelDepartman : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public short personelid { get; set; }
        public short departmanid { get; set; }
        public bool? yoneticiMi { get; set; }
        public bool? vekilMi { get; set; }
    }
}
