using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.PersonelMaasDTOs
{
    public class PersonelMaasDTO
    {

        public decimal? maas { get; set; }
        public int? maasParaBirimid { get; set; }
        public string maasParaBirimAdi { get; set; }
        public bool? maasbrut { get; set; }
        public bool? asgariUcret { get; set; }
        public int? personelMaasOdemeTurid { get; set; }
        public int? personelMaasPeriyotid { get; set; }
        public DateTime? baslangicTarih { get; set; }
        public DateTime? bitisTarih { get; set; }
        public int? personelid { get; set; }
    }
    public class PersonelMaasEkleDTO
    {
       
        public decimal? maas { get; set; }
        public int? maasParaBirimid { get; set; }
        public bool? maasbrut { get; set; }
        public bool? asgariUcret { get; set; }
        public int? personelMaasOdemeTurid { get; set; }
        public int? personelMaasPeriyotid { get; set; }
        public DateTime? baslangicTarih { get; set; }
        public DateTime? bitisTarih { get; set; }
        public int? personelid { get; set; }
    }
    public class PersonelMaasGuncelleDTO
    {
        public int personelid { get; set; }
        public decimal? maas { get; set; }
        public int? maasParaBirimid { get; set; }
        public bool? maasbrut { get; set; }
        public bool? asgariUcret { get; set; }
        public int? personelMaasOdemeTurid { get; set; }
        public int? personelMaasPeriyotid { get; set; }
        public DateTime? baslangicTarih { get; set; }
        public DateTime? bitisTarih { get; set; }
        
    }
}
