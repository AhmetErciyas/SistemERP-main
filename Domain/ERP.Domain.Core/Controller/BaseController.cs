using ERP.Domain.Core.Notification;
using ERP.Domain.Core.Response;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Domain.Core
{
    public abstract class BaseController : ControllerBase
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatorHandler _mediator;

        protected BaseController(INotificationHandler<DomainNotification> notifications,IMediatorHandler mediator)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediator = mediator;
        }

        protected IEnumerable<DomainNotification> Notifications => _notifications.GetNotifications();

        protected bool IsValidOperation()
        {
            return (!_notifications.HasNotifications());
        }
        //validedlere bakıyor hatalarlara bakıyor ve dönüyor
        protected ApiResponse<T> ApiResponse<T>(T responseData)
        {
            if (IsValidOperation())
            {
                return ApiResponseFactory.Success(responseData);
            }

            return ApiResponseFactory.Warning<T>(_notifications.GetNotifications().SelectMany(n => n.Values).ToArray());
        }

        protected void NotifyModelStateErrors()
        {
            var erros = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var erro in erros)
            {
                var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotifyError(string.Empty, erroMsg);
            }
        }

        protected void NotifyError(string code, string message)
        {
            _mediator.SendEvent(new DomainNotification(code, message));
        }

        protected void AddIdentityErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                NotifyError(result.ToString(), error.Description);
            }
        }
        /*
        #region Kullanici
        protected bool IsAuthenticated => this._httpContextAccessor.HttpContext.IsAuthenticated();

        protected int KullaniciId => this._httpContextAccessor.HttpContext.Kullanici().Id;

        protected KullaniciSessionDAO Kullanici => this._httpContextAccessor.HttpContext.Kullanici();
        #endregion
        */
    }
}
