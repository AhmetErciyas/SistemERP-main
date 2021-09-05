using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelAgi
{
    public class PersonelAgiDAO
    {
        public int   id { get; set; }
        public bool? esCalisiyorMu { get; set; }
        public bool? esinGeliriVarMi { get; set; }
        public int?  AgiKapsamindaCocukSayisi { get; set; }
        public int?   digerCocuk { get; set; }
    }
}
