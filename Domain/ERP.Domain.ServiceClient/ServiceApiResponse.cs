using ERP.Domain.Core.Response;

namespace ERP.Domain.ServiceClient
{
    public class ServiceApiResponse<T> : ApiResponse<T>
    {
        public ServiceApiResponse()
        {

        }

        public ServiceApiResponse(T data)
        {
            this.Data = data;
        }

        public ServiceApiResponse(T data, string message)
        {
            this.Data = data;
            this.Message = message;
        }

        public string Message { get; set; }
    }
}
