using ERP.Data.Entities;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.Commands.IzinGrup
{
    public class IzinGrupEkleCommand : BaseCommand<izinGrubu>
    {
        public izinGrubu izinGrubu { get; set; }
    }

    public class IzinGrupGuncelleCommand : BaseCommand<izinGrubu>
    {
        public izinGrubu izinGrubu { get; set; }
    }

    public class IzinGrupSilCommand : BaseCommand<bool>
    {
        public int izinGrubu { get; set; }
    }
}
