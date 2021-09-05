using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Personel;
using ERP.Domain.Core;
using System.Collections.Generic;

namespace ERP.Domain.Commands.Personel
{
    public class PersonelAraQuery : BaseQuery<List<PersonelDAO>>
    {
        public PersonelAraDAO Personel { get; set; }
    }

    public class PersonelQuery : BaseQuery<PersonelDAO>
    {
        public int PersonelId { get; set; }
    }
}
