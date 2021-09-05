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
    public class YetkiGrupController : BaseController
    {
        private readonly IYetkiGruplariService _yetkiGruplariService;

        public YetkiGrupController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IYetkiGruplariService yetkiGruplariService) : base(notifications, mediator)
        {
            _yetkiGruplariService = yetkiGruplariService;
        }
        [HttpGet("yetkigruplari-getir")]
        public async Task<ApiResponse<List<YetkiGrupDTO>>> YetkiGruplariGetir()
        {
            var model = await _yetkiGruplariService.YetkiGruplariGetir();
            return ApiResponse(model);
        }
        [HttpPost("yetkigrup-ekle")]
        public async Task<ApiResponse<YetkiGrupDTO>> YetkiGrupEkle(YetkiGrupEkleDTO yetkiGrupEkleDTO)
        {
            var errors = ValidatorFactory.YetkiGruplariValidator().ValidateYetkiGrupEkle(yetkiGrupEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<YetkiGrupDTO>(errors);
            var model = await _yetkiGruplariService.YetkiGrupEkle(yetkiGrupEkleDTO);
            return ApiResponse(model);
        }
        [HttpPost("yetkigrup-guncelle")]
        public async Task<ApiResponse<YetkiGrupDTO>> YetkiGrupGuncelle(YetkiGrupGuncelleDTO yetkiGrupGuncelleDTO)
        {
            var errors = ValidatorFactory.YetkiGruplariValidator().ValidateYetkiGrupGuncelle(yetkiGrupGuncelleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<YetkiGrupDTO>(errors);
            var model = await _yetkiGruplariService.YetkiGrupGuncelle(yetkiGrupGuncelleDTO);
            return ApiResponse(model);
        }

        [HttpPost("yetkigrup-sil")]
        public async Task<ApiResponse<bool>> YetkiGrupSil(int departmanid)
        {
            var errors = ValidatorFactory.YetkiGruplariValidator().ValidateYetkiGrupSil(departmanid);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _yetkiGruplariService.YetkiGrupSil(departmanid);
            return ApiResponse(model);
        }


    }
}


