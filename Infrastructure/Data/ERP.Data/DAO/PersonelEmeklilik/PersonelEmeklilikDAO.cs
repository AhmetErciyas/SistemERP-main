using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelEmeklilik
{
    public class PersonelEmeklilikDAO
    {
        public int?    ozelSigortaTurid { get; set; }
        public int?    ozelSigortaTurAdi { get; set; }
        public bool?   bireyselEmeklilikVar { get; set; }
        public double? EmeklilikKesintiOran { get; set; }
        public string  policeNo { get; set; }
        public double? PTOemeklilik { get; set; }
        public double? PTOhayat { get; set; }
        public double? PTOsaglik { get; set; }
        public double? ITOemeklilik { get; set; }
        public double? ITOhayat { get; set; }
        public double? ITOsaglik { get; set; }
    }
}
