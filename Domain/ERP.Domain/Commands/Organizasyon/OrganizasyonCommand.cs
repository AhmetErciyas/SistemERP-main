using ERP.Data.Entities;
using ERP.Domain.Core;

namespace ERP.Domain.Commands.Organizasyon
{
    public class DepartmanEkleCommand : BaseCommand<departman>
    {
        public departman departman { get; set; }
    }

    public class DepartmanGuncelleCommand : BaseCommand<departman>
    {
        public departman Departman { get; set; }
    }

    public class DepartmanSilCommand : BaseCommand<bool>
    {
        public int DepartmanId { get; set; }
    }

    public class UnvanEkleCommand : BaseCommand<unvan>
    {
        public unvan Unvan { get; set; }
    }

    public class UnvanGuncelleCommand : BaseCommand<unvan>
    {
        public unvan Unvan { get; set; }
    }

    public class UnvanSilCommand : BaseCommand<bool>
    {
        public int UnvanId { get; set; }
    }

    public class KademeEkleCommand : BaseCommand<kademe>
    {
        public kademe Kademe { get; set; }
    }

    public class KademeGuncelleCommand : BaseCommand<kademe>
    {
        public kademe Kademe { get; set; }
    }

    public class KademeSilCommand : BaseCommand<bool>
    {
        public int KademeId { get; set; }
    }
}
