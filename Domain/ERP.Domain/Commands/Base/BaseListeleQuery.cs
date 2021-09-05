using ERP.Domain.Core;
using System.Collections.Generic;

namespace ERP.Domain.Commands.Base
{
    public class BaseListeleQuery<TEntity> : BaseQuery<List<TEntity>>
    {
        public object Data { get; set; }
    }
}