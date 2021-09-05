using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using ERP.Application.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using ERP.WebApi.Validation;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KullaniciYetkileriController : BaseController
    {
        private readonly IKullaniciYetkileriService _kullaniciYetkileriService;

        public KullaniciYetkileriController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IKullaniciYetkileriService kullaniciYetkileriService) : base(notifications, mediator)
        {
            _kullaniciYetkileriService = kullaniciYetkileriService;
        }
        [HttpGet("kullaniciyetki-getir")]
        public async Task<ApiResponse<List<KullaniciYetkiDTO>>> KullaniciYetkileriGetir()
        {
            var model = await _kullaniciYetkileriService.KullaniciYetkileriGetir();
            return ApiResponse(model);
        }
        [HttpPost("kullaniciyetki-ekle")]
        public async Task<ApiResponse<KullaniciYetkiDTO>> KullaniciYetkiEkle(KullaniciYetkiEkleDTO kullaniciYetkiEkleDTO)
        {
            var errors = ValidatorFactory.KullaniciYetkileriValidator().ValidateKullaniciYetkiEkle(kullaniciYetkiEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<KullaniciYetkiDTO>(errors);
            var model = await _kullaniciYetkileriService.KullaniciYetkiEkle(kullaniciYetkiEkleDTO);
            return ApiResponse(model);
        }
        [HttpPost("kullaniciyetki-guncelle")]
        public async Task<ApiResponse<KullaniciYetkiDTO>> KullaniciYetkiGuncelle(KullaniciYetkiGuncelleDTO kullaniciYetkiGuncelleDTO)
        {
            var errors = ValidatorFactory.KullaniciYetkileriValidator().ValidateKullaniciYetkiGuncelle(kullaniciYetkiGuncelleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<KullaniciYetkiDTO>(errors);
            var model = await _kullaniciYetkileriService.KullaniciYetkiGuncelle(kullaniciYetkiGuncelleDTO);
            return ApiResponse(model);
        }

        [HttpPost("kullaniciyetki-sil")]
        public async Task<ApiResponse<bool>> YetkiGrupSil(int yetkiid)
        {
            var errors = ValidatorFactory.KullaniciYetkileriValidator().ValidateKullaniciYetkiSil(yetkiid);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _kullaniciYetkileriService.KullaniciYetkiSil(yetkiid);
            return ApiResponse(model);
        }


    }
}