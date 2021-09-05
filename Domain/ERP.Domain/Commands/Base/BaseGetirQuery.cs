using ERP.Domain.Core;

namespace ERP.Domain.Commands.Base
{
    public class BaseGetirQuery<TIdentity, TResponse> : BaseQuery<TResponse>
    {
        public TIdentity Identity { get; set; }
    }
}