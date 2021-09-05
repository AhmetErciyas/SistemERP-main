using ERP.Data;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Base
{
    public class BaseListeleQueryHandler<TEntity> : IRequestHandler<BaseListeleQuery<TEntity>, List<TEntity>> where TEntity : class
    {
        protected readonly IRepository<TEntity> _repository;

        public BaseListeleQueryHandler(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async virtual Task<List<TEntity>> Handle(BaseListeleQuery<TEntity> request, CancellationToken cancellationToken)
        {
            return (await _repository.All()).ToList();
        }
    }
}