using ERP.Data;
using MediatR;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ERP.Domain.Core
{
    public abstract class BaseCommandHandler
    {
        private const string COMMIT_DEFAULT_ERROR_MESSAGE = "There was an error with transaction. ";

        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMediatorHandler _mediator;
        protected readonly INotificationHandler<DomainNotification> _notifications;

        protected BaseCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
            _notifications = notifications;
        }

        protected void AddError(string error)
        {
            _mediator.SendEvent(new DomainNotification(string.Empty, error));
        }

        protected async Task<bool> Commit(string message = COMMIT_DEFAULT_ERROR_MESSAGE)
        {
            var result = true;

            try
            {
                if (!await _unitOfWork.Commit())
                {
                    AddError(message);
                    result = false;
                }
            }
            catch (Exception ex)
            {
                message += ex.Message;
                if (!string.IsNullOrEmpty(ex.InnerException.ToString()))
                    message += ex.InnerException.ToString();

                AddError(message);
                result = false;

                if (Debugger.IsAttached)
                    Debug.WriteLine(message);
            }

            return result;
        }
    }
}