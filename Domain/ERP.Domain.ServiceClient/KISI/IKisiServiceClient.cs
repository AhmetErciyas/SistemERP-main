using System.Threading.Tasks;

namespace ERP.Domain.ServiceClient.KISI
{
    public interface IKisiServiceClient
    {
        Task<ServiceApiResponse<bool>> TCKimlikDogrulama(ulong tCKimlikNo, string ad, string soyad, ushort dogumYili);
    }
}
