using System.Threading.Tasks;

namespace ERP.Domain.ServiceClient.SMS
{
    public interface ISMSServiceClient
    {
        Task<ServiceApiResponse<bool>> SMSGonder(SMSRequestModel model);
    }
}
