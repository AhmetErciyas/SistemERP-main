using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ERP.Domain.ServiceClient.KISI
{
    public class KisiServiceClient : IKisiServiceClient
    {

        private IConfiguration _configuration;

        public KisiServiceClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ServiceApiResponse<bool>> TCKimlikDogrulama(ulong tCKimlikNo, string ad, string soyad, ushort dogumYili)
        {
            TCKimlikDogrulama.TCKimlikNoDogrula tcKimlikDogrulama = new TCKimlikDogrulama.TCKimlikNoDogrula();
            tcKimlikDogrulama.TCKimlikNo = tCKimlikNo;
            tcKimlikDogrulama.Ad = ad;
            tcKimlikDogrulama.Soyad = soyad;
            tcKimlikDogrulama.DogumYili = dogumYili;

            TCKimlikDogrulama.EnvelopeBody tcKimlikEnvelopeBody = new TCKimlikDogrulama.EnvelopeBody();
            tcKimlikEnvelopeBody.TCKimlikNoDogrula = tcKimlikDogrulama;

            TCKimlikDogrulama.Envelope tcKimlikEnvelope = new TCKimlikDogrulama.Envelope();
            tcKimlikEnvelope.Body = tcKimlikEnvelopeBody;

            XmlSerializer xsSubmit = new XmlSerializer(typeof(TCKimlikDogrulama.Envelope));
            var subReq = new TCKimlikDogrulama.Envelope();
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, tcKimlikEnvelope);
                    xml = sww.ToString();
                }
            }

            XDocument doc = XDocument.Parse(xml);

            String sDoc = doc.ToString();

            byte[] byteArray = Encoding.UTF8.GetBytes(sDoc);

            CookieContainer cookies = new CookieContainer();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx");
            
            request.Method = "POST";
            request.ContentType = "text/xml;charset=\"utf-8\"";

            request.ContentLength = byteArray.Length;

            request.Headers.Add("SOAPAction", "http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula");

            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                String status = ((HttpWebResponse)response).StatusDescription;

                reader.Close();
                dataStream.Close();
                response.Close();

                if (responseFromServer.Contains("<TCKimlikNoDogrulaResult>true</TCKimlikNoDogrulaResult>"))
                {
                    return new ServiceApiResponse<bool>(true);
                }
                else
                {
                    return new ServiceApiResponse<bool>(false);
                }
            }
            catch (Exception ex)
            {
                return new ServiceApiResponse<bool>(false, ex.Message);
            }
        }
    }
}
