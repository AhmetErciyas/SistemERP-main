using ERP.Domain.Core;
using System;

namespace ERP.Domain.Commands
{
    public class FirmaSubeEkleCommand : BaseCommand<Data.Entities.sube>
    {
        public Data.Entities.sube FirmaSube { get; set; }
    }

    public class FirmaSubeGuncelleCommand : BaseCommand<Data.Entities.sube>
    {
        public Data.Entities.sube FirmaSube { get; set; }
    }

    public class FirmaSubeSilCommand : BaseCommand<bool>
    {
        public int FirmaSubeId { get; set; }
    }
}
