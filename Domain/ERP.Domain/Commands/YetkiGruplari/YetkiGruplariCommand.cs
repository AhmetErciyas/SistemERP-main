using ERP.Data.Entities;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.Commands.YetkiGruplari
{
    
    public class YetkiGruplariEkleCommand : BaseCommand<yetkiGruplari>
    {
        public yetkiGruplari yetkiGruplari { get; set; }
    }

    public class YetkiGruplariGuncelleCommand : BaseCommand<yetkiGruplari>
    {
        public yetkiGruplari yetkiGruplari { get; set; }

    }

    public class YetkiGruplariSilCommand : BaseCommand<bool>
    {
        public int yetkiGruplariId { get; set; }
    }
}
