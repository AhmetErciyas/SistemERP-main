using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.YetkiGruplariDetayDTOs
{
    public class YetkiGrupDetayDTO
    {
        public int Id { get; set; }
        public int YetkiId { get; set; }
        public int GrupId { get; set; }
        public string YetkiAdi { get; set; }
        public string GrupAdi { get; set; }
    }
    public class YetkiGrupDetayEkleDTO
    {
        public int YetkiId { get; set; }
        public int GrupId { get; set; }
    }
    public class YetkiGrupDetayGuncelleDTO
    {
        public int Id { get; set; }
        public int YetkiId { get; set; }
        public int GrupId { get; set; }
    }
}
