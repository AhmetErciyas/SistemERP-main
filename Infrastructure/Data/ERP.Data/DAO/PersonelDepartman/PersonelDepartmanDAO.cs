using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.DAO.PersonelDepartman
{
    public class PersonelDepartmanDAO
    {
        public int id { get; set; }
        public int personelid { get; set; }

        public int    departmanid { get; set; }
        public string departmanAdi { get; set; }
        public bool?  yoneticiMi { get; set; }
        public bool?  vekilMi { get; set; }

    }
}
