using ERP.Domain.Core.Response;
using System.Linq;

namespace ERP.Domain.Core
{
    public static class ApiResponseFactory
    {
        public static ApiResponse Success()
        {
            return new ApiResponse
            {
                Success = true
            };
        }

        public static ApiResponse<T> Success<T>(T data)
        {
            return new ApiResponse<T>
            {
                Success = true,
                Data = data
            };
        }

        public static ApiResponse Error(string[] messages)
        {
            return new ApiResponse
            {
                Success = false,
                Messages = messages.ToList()
            };
        }

        public static ApiResponse<T> Warning<T>(string[] messages)
        {
            return new ApiResponse<T>
            {
                Success = false,
                Messages = messages.ToList()
            };
        }
    }
}
