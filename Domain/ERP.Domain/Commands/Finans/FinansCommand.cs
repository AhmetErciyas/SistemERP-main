using ERP.Data.Entities;
using ERP.Domain.Core;

namespace ERP.Domain.Commands.Finans
{
    public class FinansFirmaEkleCommand : BaseCommand<firma>
    {
        public firma Firma { get; set; }
    }
}
