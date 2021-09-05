using System.Threading.Tasks;

namespace ERP.Domain.Core
{
    public interface IMediatorHandler
    {
        #region Command

        Task<TResponse> SendCommand<TRequest, TResponse>(TRequest @command) where TRequest : BaseCommand<TResponse>;

        Task<TResponse> SendCommand<TRequest, TResponse>() where TRequest : BaseCommand<TResponse>;

        #endregion Command

        #region Query

        Task<TResponse> SendQuery<TRequest, TResponse>(TRequest query) where TRequest : BaseQuery<TResponse>;

        Task<TResponse> SendQuery<TRequest, TResponse>() where TRequest : BaseQuery<TResponse>;

        Task<TResponse> SendQueryPaged<TRequest, TResponse>() where TRequest : BasePagedQuery<TResponse>;

        Task<TResponse> SendQueryPaged<TRequest, TResponse>(TRequest query) where TRequest : BasePagedQuery<TResponse>;

        #endregion Query

        #region Event

        Task SendEvent<TRequest>(TRequest @event) where TRequest : BaseEvent;

        #endregion Event
    }
}
