using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.PersonelTabiKanunDTOs
{

    public class PersonelTabiKanunDTO
    {

        public bool? GVHesaplansinMi { get; set; }
        public decimal? GVmuafiyet { get; set; }
        public bool? GVMuafiyetiNeteEkle { get; set; }
        public bool? SGKHesaplansinMi { get; set; }
        public decimal? UVSKisveren { get; set; }
        public decimal? UVSKisci { get; set; }
        public decimal? GSSisveren { get; set; }
        public decimal? GSSisci { get; set; }
        public decimal? KVSKisveren { get; set; }
        public bool? IssizlikHesaplansinMi { get; set; }
        public decimal? Issizlikisveren { get; set; }
        public decimal? Issizlikisci { get; set; }
        public bool? DVHesaplansinMi { get; set; }
        public decimal? DamgaVergisi { get; set; }
        public bool? DVMuafiyetiNeteEkle { get; set; }

    }
    public class PersonelTabiKanunEkleDTO
    {
        public int personelKanunId { get; set; }
        public bool? GVHesaplansinMi { get; set; }
        public decimal? GVmuafiyet { get; set; }
        public bool? GVMuafiyetiNeteEkle { get; set; }
        public bool? SGKHesaplansinMi { get; set; }
        public decimal? UVSKisveren { get; set; }
        public decimal? UVSKisci { get; set; }
        public decimal? GSSisveren { get; set; }
        public decimal? GSSisci { get; set; }
        public decimal? KVSKisveren { get; set; }
        public bool? IssizlikHesaplansinMi { get; set; }
        public decimal? Issizlikisveren { get; set; }
        public decimal? Issizlikisci { get; set; }
        public bool? DVHesaplansinMi { get; set; }
        public decimal? DamgaVergisi { get; set; }
        public bool? DVMuafiyetiNeteEkle { get; set; }

    }
    public class PersonelTabiKanunGuncelleDTO
    {
        public int personelid { get; set; }
        public int? personelKanunid { get; set; }
        public bool? GVHesaplansinMi { get; set; }
        public decimal? GVmuafiyet { get; set; }
        public bool? GVMuafiyetiNeteEkle { get; set; }
        public bool? SGKHesaplansinMi { get; set; }
        public decimal? UVSKisveren { get; set; }
        public decimal? UVSKisci { get; set; }
        public decimal? GSSisveren { get; set; }
        public decimal? GSSisci { get; set; }
        public decimal? KVSKisveren { get; set; }
        public bool? IssizlikHesaplansinMi { get; set; }
        public decimal? Issizlikisveren { get; set; }
        public decimal? Issizlikisci { get; set; }
        public bool? DVHesaplansinMi { get; set; }
        public decimal? DamgaVergisi { get; set; }
        public bool? DVMuafiyetiNeteEkle { get; set; }
       
    }
}
