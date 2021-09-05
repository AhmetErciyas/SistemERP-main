using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.YetkilerDTOs
{
    public class YetkiDTO
    {
        public int id { get; set; }
        public string adi { get; set; }
      
    }
    public class YetkiEkleDTO
    {
        public string adi { get; set; }
    }
    public class YetkiGuncelleDTO
    {
        public int Id { get; set; }
        public string adi { get; set; }
    }
}
