using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.FirmaSubeDTOs
{
    public class FirmaSubeDTO
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public string Adi { get; set; }
        public string FirmaAdi { get; set; }

    }
    public class FirmaSubeEkleDTO
    {
        public int FirmaId { get; set; }
        public string Adi { get; set; }
    }

    public class FirmaSubeGuncelleDTO
    {
        public int id { get; set; }
        public int? firmaid { get; set; }
        public string adi { get; set; }
    }

    public class FirmaSubeAraDTO : BasePagedDTO
    {
        public int FirmaId { get; set; }
        public string Adi { get; set; }
    }
}
