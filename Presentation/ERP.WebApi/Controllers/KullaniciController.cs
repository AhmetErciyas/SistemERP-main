using ERP.Application.DTOs.KullaniciDTOs;
using ERP.Application.Interfaces;
using ERP.Data.DAO.Kullanici;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using ERP.WebApi.Authorization;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class KullaniciController : BaseController
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IKullaniciService _kullaniciService;

        public KullaniciController(IHttpContextAccessor httpContextAccessor,
                                    INotificationHandler<DomainNotification> notifications,
                                    IMediatorHandler mediator,
                                    IKullaniciService kullaniciService) : base(notifications, mediator)
        {
            _httpContextAccessor = httpContextAccessor;
            _kullaniciService = kullaniciService;
        }

        #region Auth

        [AllowAnonymous]
        [HttpPost("giris")]
        public async Task<ApiResponse<KullaniciToken>> KullaniciGiris(KullaniciGirisDTO kullaniciGirisDTO)
        {
            var kullanici = await _kullaniciService.GirisYap(kullaniciGirisDTO);
            return ApiResponse(kullanici);
        }


        [PermissionRequirement(Permissions.GetKullaniciList)]
        [HttpPost("ekle")]
        public async Task<ApiResponse<KullaniciDTO>> KullaniciEkle(KullaniciDTO kullaniciGirisDTO)
        {
            var kullanici = await _kullaniciService.KullaniciEkle(kullaniciGirisDTO);
            return ApiResponse(kullanici);
        }
        #endregion
    }
}