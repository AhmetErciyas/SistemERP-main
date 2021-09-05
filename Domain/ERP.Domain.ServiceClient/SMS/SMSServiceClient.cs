using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace ERP.Domain.ServiceClient.SMS
{
    public class SMSServiceClient : ISMSServiceClient
    {

        private IConfiguration _configuration;

        public SMSServiceClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ServiceApiResponse<bool>> SMSGonder(SMSRequestModel model)
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
