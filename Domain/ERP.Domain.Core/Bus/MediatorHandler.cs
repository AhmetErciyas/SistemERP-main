using MediatR;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ERP.Domain.Core
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Command

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Task<TResponse> SendCommand<TRequest, TResponse>(TRequest command) where TRequest : BaseCommand<TResponse>
        {
            return _mediator.Send(command);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Task<TResponse> SendCommand<TRequest, TResponse>() where TRequest : BaseCommand<TResponse>
        {
            return _mediator.Send((TRequest)Activator.CreateInstance(typeof(TRequest)));
        }

        #endregion Command

        #region Query

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Task<TResponse> SendQuery<TRequest, TResponse>(TRequest query) where TRequest : BaseQuery<TResponse>
        {
            return _mediator.Send(query);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Task<TResponse> SendQuery<TRequest, TResponse>() where TRequest : BaseQuery<TResponse>
        {
            return _mediator.Send((TRequest)Activator.CreateInstance(typeof(TRequest)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Task<TResponse> SendQueryPaged<TRequest, TResponse>() where TRequest : BasePagedQuery<TResponse>
        {
            return _mediator.Send((TRequest)Activator.CreateInstance(typeof(TRequest)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Task<TResponse> SendQueryPaged<TRequest, TResponse>(TRequest query) where TRequest : BasePagedQuery<TResponse>
        {
            return _mediator.Send(query);
        }

        #endregion Query

        #region Event

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Task SendEvent<TRequest>(TRequest @event) where TRequest : BaseEvent
        {
            return _mediator.Publish(@event);
        }

        #endregion Event
    }
}
