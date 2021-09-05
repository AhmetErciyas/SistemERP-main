using ERP.Data;
using ERP.Data.Entities;
using ERP.Domain.Commands.Base;

namespace ERP.Domain.Commands.Finans
{
    public class FirmaTurGetirQueryHandler : BaseGetirQueryHandler<int, firmaTur>
    {
        public FirmaTurGetirQueryHandler(IRepository<firmaTur> repository) : base(repository)
        {
        }
    }

    public class FirmaTurListeleQueryHandler : BaseListeleQueryHandler<firmaTur>
    {
        public FirmaTurListeleQueryHandler(IRepository<firmaTur> repository) : base(repository)
        {

        }
    }
}