using ERP.Data.Entities;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.Commands.YetkiGruplariDetay
{
   
    public class YetkiGruplariDetayEkleCommand : BaseCommand<yetkiGruplariDetay>
    {
        public yetkiGruplariDetay yetkiGruplariDetay { get; set; }
    }

    public class YetkiGruplariDetayGuncelleCommand : BaseCommand<yetkiGruplariDetay>
    {
        public yetkiGruplariDetay yetkiGruplariDetay { get; set; }

    }

    public class YetkiGruplariDetaySilCommand : BaseCommand<bool>
    {
        public int yetkiGruplariDetayId { get; set; }
    }
}
