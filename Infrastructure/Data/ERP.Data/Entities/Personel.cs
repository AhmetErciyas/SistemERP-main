using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    [Table("personel", Schema = "Personel")]
    public partial class personel : ERP.Data.Entity, ERP.Data.IAggregateRoot
    {
        public personel()
        {
            ekGelirGider = new HashSet<ekGelirGider>();
            kullanici = new HashSet<kullanici>();
            personelDepartman = new HashSet<personelDepartman>();
        }

        [Key]
        public int id { get; set; }
        public int? subeid { get; set; }
        public int kademeid { get; set; }
        public int unvanid { get; set; }
        public int sigortaTurid { get; set; }
        public int sigortaDurumid { get; set; }
        public int? meslekid { get; set; }
        public int? grupid { get; set; }
        public int askerlikDurumid { get; set; }
        [StringLength(16)]
        public string sicilNo { get; set; }
        [StringLength(100)]
        public string adi { get; set; }
        [StringLength(100)]
        public string soyadi { get; set; }
        public int? vergiDaireid { get; set; }
        [StringLength(15)]
        public string vergiNo { get; set; }
        [StringLength(15)]
        public string sigortaNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? iseGirisTarih { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? isdenCikisTarih { get; set; }
        public int? ogrenimDurumid { get; set; }
        [StringLength(100)]
        public string okul { get; set; }
        [StringLength(100)]
        public string bolum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? mezuniyetTarih { get; set; }
        public int? engellilikDurumid { get; set; }
        public bool? engellilikIndirim { get; set; }
        public bool? eskiHukumlu { get; set; }
        public bool? terorMagduru { get; set; }
        public int? sozlesmeTurid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? sozlesmeBitisTarih { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? kidemTarih { get; set; }
        public int? firmaid { get; set; }
        public int? departmanid { get; set; }
        public int? istenAyrilmaNedenid { get; set; }
        public bool? silindimi { get; set; }

        [ForeignKey(nameof(askerlikDurumid))]
        [InverseProperty("personel")]
        public virtual askerlikDurum askerlikDurum { get; set; }
        [ForeignKey(nameof(departmanid))]
        [InverseProperty("personel")]
        public virtual departman departman { get; set; }
        [ForeignKey(nameof(engellilikDurumid))]
        [InverseProperty("personel")]
        public virtual engellilikDurum engellilikDurum { get; set; }
        [ForeignKey(nameof(firmaid))]
        [InverseProperty("personel")]
        public virtual firma firma { get; set; }
        [ForeignKey(nameof(grupid))]
        [InverseProperty("personel")]
        public virtual grup grup { get; set; }
        [ForeignKey(nameof(istenAyrilmaNedenid))]
        [InverseProperty(nameof(istenAyrilmaNedenleri.personel))]
        public virtual istenAyrilmaNedenleri istenAyrilmaNeden { get; set; }
        [ForeignKey(nameof(kademeid))]
        [InverseProperty("personel")]
        public virtual kademe kademe { get; set; }
        [ForeignKey(nameof(ogrenimDurumid))]
        [InverseProperty("personel")]
        public virtual ogrenimDurum ogrenimDurum { get; set; }
        [ForeignKey(nameof(sigortaDurumid))]
        [InverseProperty("personel")]
        public virtual sigortaDurum sigortaDurum { get; set; }
        [ForeignKey(nameof(sigortaTurid))]
        [InverseProperty("personel")]
        public virtual sigortaTur sigortaTur { get; set; }
        [ForeignKey(nameof(sozlesmeTurid))]
        [InverseProperty("personel")]
        public virtual sozlesmeTur sozlesmeTur { get; set; }
        [ForeignKey(nameof(subeid))]
        [InverseProperty("personel")]
        public virtual sube sube { get; set; }
        [ForeignKey(nameof(unvanid))]
        [InverseProperty("personel")]
        public virtual unvan unvan { get; set; }
        [ForeignKey(nameof(vergiDaireid))]
        [InverseProperty("personel")]
        public virtual vergiDaire vergiDaire { get; set; }
        [InverseProperty("personel")]
        public virtual digerBilgiler digerBilgiler { get; set; }
        [InverseProperty("personel")]
        public virtual personelAgi personelAgi { get; set; }
        [InverseProperty("personel")]
        public virtual personelBankaHesap personelBankaHesap { get; set; }
        [InverseProperty("personel")]
        public virtual personelEmeklilik personelEmeklilik { get; set; }
        [InverseProperty("personel")]
        public virtual personelKimlik personelKimlik { get; set; }
        [InverseProperty("personel")]
        public virtual personelMaas personelMaas { get; set; }
        [InverseProperty("personel")]
        public virtual personelTabiKanun personelTabiKanun { get; set; }
        [InverseProperty("personel")]
        public virtual ICollection<ekGelirGider> ekGelirGider { get; set; }
        [InverseProperty("personel")]
        public virtual ICollection<kullanici> kullanici { get; set; }
        [InverseProperty("personel")]
        public virtual ICollection<personelDepartman> personelDepartman { get; set; }
    }
}
