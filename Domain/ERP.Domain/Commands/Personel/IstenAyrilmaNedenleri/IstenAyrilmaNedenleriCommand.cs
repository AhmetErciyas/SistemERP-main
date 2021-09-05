using ERP.Data.Entities;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.Commands.IstenAyrilmaNedenleri
{
    public class IstenAyrilmaNedenleriEkleCommand : BaseCommand<istenAyrilmaNedenleri>
    {
        public istenAyrilmaNedenleri IstenAyrilmaNedenleri { get; set; }
    }

    public class IstenAyrilmaNedenleriGuncelleCommand : BaseCommand<istenAyrilmaNedenleri>
    {
        public istenAyrilmaNedenleri IstenAyrilmaNedenleri { get; set; }
    }

    public class IstenAyrilmaNedenleriSilCommand : BaseCommand<bool>
    {
        public int IstenAyrilmaNedenleri { get; set; }
    }
}
