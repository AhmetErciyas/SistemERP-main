using ERP.Data.DAO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.FirmaSube
{
    public class FirmaSubeAraDAO : BasePagedDAO
    {
        public string Adi { get; set; }
        public int ?FirmaId { get; set; }
    }
}
