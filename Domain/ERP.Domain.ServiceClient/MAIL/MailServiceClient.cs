using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace ERP.Domain.ServiceClient.MAIL
{
    public class MailServiceClient : IMailServiceClient
    {

        private IConfiguration _configuration;

        public MailServiceClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ServiceApiResponse<bool>> MailGonder(MailRequestModel model)
        {
            try
            {
                //TODO : 
            }
            catch (Exception ex)
            {
            }

            return null;
        }

    }
}
