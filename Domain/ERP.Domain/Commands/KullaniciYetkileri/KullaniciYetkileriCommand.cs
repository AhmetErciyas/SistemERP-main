using ERP.Data.Entities;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.Commands.KullaniciYetkileri
{
   
    public class KullaniciYetkileriEkleCommand : BaseCommand<kullaniciYetkileri>
    {
        public kullaniciYetkileri kullaniciYetkileri { get; set; }
    }

    public class KullaniciYetkileriGuncelleCommand : BaseCommand<kullaniciYetkileri>
    {
        public kullaniciYetkileri kullaniciYetkileri { get; set; }

    }

    public class KullaniciYetkileriSilCommand : BaseCommand<bool>
    {
        public int kullaniciYetkileriId { get; set; }
    }
}
