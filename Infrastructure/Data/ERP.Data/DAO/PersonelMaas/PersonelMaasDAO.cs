using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelMaas
{
    public class PersonelMaasDAO
    {
        public decimal? maas { get; set; }
        public int? maasParaBirimid { get; set; }
        public string maasParaBirimAdi { get; set; }
        public bool? maasbrut { get; set; }
        public bool? asgariUcret { get; set; }
        public int? personelMaasOdemeTurid { get; set; }
        public int? personelMaasPeriyotid { get; set; }
        public string personelMaasOdemeTurAdi { get; set; }
        public string personelMaasPeriyotAdi { get; set; }
        public DateTime? baslangicTarih { get; set; }
        public DateTime? bitisTarih { get; set; }
        public int? personelid { get; set; }
    }
}
