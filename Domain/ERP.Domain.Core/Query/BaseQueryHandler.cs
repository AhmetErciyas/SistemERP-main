using MediatR;

namespace ERP.Domain.Core
{
    public abstract class BaseQueryHandler
    {
        protected readonly IMediatorHandler _mediator;
        protected readonly INotificationHandler<DomainNotification> _notifications;

        protected BaseQueryHandler(IMediatorHandler mediator, INotificationHandler<DomainNotification> notifications)
        {
            _mediator = mediator;
            _notifications = notifications;
        }
    }
}
