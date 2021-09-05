using ERP.Domain.Core;
using System;

namespace ERP.Domain.Commands
{
    public class PersonelEkleCommand : BaseCommand<Data.Entities.personel>
    {
        public Data.Entities.personel Personel { get; set; }
    }

    public class PersonelGuncelleCommand : BaseCommand<Data.Entities.personel>
    {
        public Data.Entities.personel Personel { get; set; }
    }

    public class PersonelSilCommand : BaseCommand<bool>
    {
        public int PersonelId { get; set; }
    }
}
