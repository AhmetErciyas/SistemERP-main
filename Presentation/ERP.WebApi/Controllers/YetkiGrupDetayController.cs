using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using ERP.Application.DTOs.YetkiGruplariDTOs;
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
    public class YetkiGrupDetayController : BaseController
    {
        private readonly IYetkiGruplariDetayService _yetkiGruplariDetayService;

        public YetkiGrupDetayController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IYetkiGruplariDetayService yetkiGruplariDetayService) : base(notifications, mediator)
        {
            _yetkiGruplariDetayService = yetkiGruplariDetayService;
        }
        [HttpGet("yetkigruplaridetay-getir")]
        public async Task<ApiResponse<List<YetkiGrupDetayDTO>>> YetkiGruplariDetayGetir()
        {
            var model = await _yetkiGruplariDetayService.YetkiGrupDetaylariGetir();
            return ApiResponse(model);
        }
        [HttpPost("yetkigrupdetay-ekle")]
        public async Task<ApiResponse<YetkiGrupDetayDTO>> YetkiGrupDetayEkle(YetkiGrupDetayEkleDTO yetkiGrupDetayEkleDTO)
        {
            var errors = ValidatorFactory.YetkiGruplariDetayValidator().ValidateYetkiGruplariDetayEkle(yetkiGrupDetayEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<YetkiGrupDetayDTO>(errors);
            var model = await _yetkiGruplariDetayService.YetkiGrupDetayEkle(yetkiGrupDetayEkleDTO);
            return ApiResponse(model);
        }
        [HttpPost("yetkigrupdetay-guncelle")]
        public async Task<ApiResponse<YetkiGrupDetayDTO>> YetkiGrupDetayGuncelle(YetkiGrupDetayGuncelleDTO yetkiGrupDetayGuncelleDTO)
        {
            var errors = ValidatorFactory.YetkiGruplariDetayValidator().ValidateYetkiGruplariDetayGuncelle(yetkiGrupDetayGuncelleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<YetkiGrupDetayDTO>(errors);
            var model = await _yetkiGruplariDetayService.YetkiGrupDetayGuncelle(yetkiGrupDetayGuncelleDTO);
            return ApiResponse(model);
        }

        [HttpPost("yetkigrupdetay-sil")]
        public async Task<ApiResponse<bool>> YetkiGrupDetaySil(int yetkiGrupDetayId)
        {
            var errors = ValidatorFactory.YetkiGruplariDetayValidator().ValidateYetkiGruplariDetaySil(yetkiGrupDetayId);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _yetkiGruplariDetayService.YetkiGrupDetaySil(yetkiGrupDetayId);
            return ApiResponse(model);
        }

        
    }
}

