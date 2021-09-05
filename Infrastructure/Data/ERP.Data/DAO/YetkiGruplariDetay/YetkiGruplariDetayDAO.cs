using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.YetkiGruplariDetay
{
    public class YetkiGruplariDetayDAO
    {
        public int id { get; set; }
        public int YetkiId { get; set; }
        public int GrupId { get; set; }
        public string YetkiAdi { get; set; }
        public string GrupAdi { get; set; }
    }
}
