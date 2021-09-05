using ERP.Data.Entities;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.Commands.PersonelKanun
{
    public class PersonelKanunEKleCommand : BaseCommand<personelKanun>
    {
        public personelKanun personelKanun { get; set; }
    }

    public class PersonelKanunGuncelleCommand : BaseCommand<personelKanun>
    {
        public personelKanun personelKanun { get; set; }
    }

    public class PersonelKanunSilCommand : BaseCommand<bool>
    {
        public int personelKanunId { get; set; }
    }
}
