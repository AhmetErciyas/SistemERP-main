using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using ERP.Domain.Core;
using System.Collections.Generic;

namespace ERP.Domain.Commands.Organizasyon
{
    public class DepartmanAraQuery : BaseQuery<List<DepartmanDAO>>
    {
        public departman Departman { get; set; }
    }

    public class UnvanAraQuery : BaseQuery<List<UnvanDAO>>
    {
        public unvan Unvan { get; set; }
    }

    public class KademeAraQuery : BaseQuery<List<KademeDAO>>
    {
        public kademe Kademe { get; set; }
    }
}
