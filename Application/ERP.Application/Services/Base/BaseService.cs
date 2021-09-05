using ERP.Application.AutoMapper;
using ERP.Domain.Core;
using System;

namespace ERP.Application
{
    public abstract class BaseService
    {
        protected readonly IMediatorHandler _mediator;
        protected readonly IERPMapper _mapper;

        protected BaseService(IMediatorHandler mediator, IERPMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
