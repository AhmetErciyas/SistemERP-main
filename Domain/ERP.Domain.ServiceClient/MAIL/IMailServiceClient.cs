using System.Threading.Tasks;

namespace ERP.Domain.ServiceClient.MAIL
{
    public interface IMailServiceClient
    {
        Task<ServiceApiResponse<bool>> MailGonder(MailRequestModel model);
    }
}
