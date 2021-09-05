using ERP.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Base
{
    public class BaseGetirQueryHandler<TIdentity, TEntity> :
        IRequestHandler<BaseGetirQuery<TIdentity, TEntity>, TEntity> where TEntity : class
    {
        protected readonly IRepository<TEntity> _repository;

        public BaseGetirQueryHandler(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async virtual Task<TEntity> Handle(BaseGetirQuery<TIdentity, TEntity> request, CancellationToken cancellationToken)
        {
            return await _repository.GetAsync(request.Identity);
        }
    }
}