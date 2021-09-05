using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.FirmaSube
{
    public class FirmaSubeDAO
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int ?FirmaId { get; set; }
        public string FirmaAdi { get; set; }

    }
}
