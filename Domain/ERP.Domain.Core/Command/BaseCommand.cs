using ERP.Data;
using MediatR;
using System;

namespace ERP.Domain.Core
{
    public abstract class BaseCommand<TResponse> : IAggregateRoot, IRequest<TResponse>
    {
        public DateTime Timestamp { get; private set; }

        protected BaseCommand()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}