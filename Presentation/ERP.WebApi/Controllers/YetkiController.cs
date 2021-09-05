using ERP.Application.DTOs.YetkilerDTOs;
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
    public class YetkiController : BaseController
    {
        private readonly IYetkilerService _yetkilerService;

        public YetkiController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IYetkilerService yetkilerService) : base(notifications, mediator)
        {
            _yetkilerService = yetkilerService;
        }
        [HttpGet("yetki-getir")]
        public async Task<ApiResponse<List<YetkiDTO>>> YetkiGruplariGetir()
        {
            var model = await _yetkilerService.YetkileriGetir();
            return ApiResponse(model);
        }
        //[HttpPost("yetki-ekle")]
        //public async Task<ApiResponse<YetkiDTO>> YetkiGrupEkle(YetkiEkleDTO yetkiEkleDTO)
        //{
        //    var errors = ValidatorFactory.YetkilerValidator().ValidateYetkiEkle(yetkiEkleDTO);
        //    if (errors.Length != 0)
        //        return ApiResponseFactory.Warning<YetkiDTO>(errors);
        //    var model = await _yetkilerService.YetkiEkle(yetkiEkleDTO);
        //    return ApiResponse(model);
        //}
        //[HttpPost("yetki-guncelle")]
        //public async Task<ApiResponse<YetkiDTO>> YetkiGrupGuncelle(YetkiGuncelleDTO yetkiGuncelleDTO)
        //{
        //    var errors = ValidatorFactory.YetkilerValidator().ValidateYetkiGuncelle(yetkiGuncelleDTO);
        //    if (errors.Length != 0)
        //        return ApiResponseFactory.Warning<YetkiDTO>(errors);
        //    var model = await _yetkilerService.YetkiGuncelle(yetkiGuncelleDTO);
        //    return ApiResponse(model);
        //}

        //[HttpPost("yetki-sil")]
        //public async Task<ApiResponse<bool>> YetkiGrupSil(int yetkiid)
        //{
        //    var errors = ValidatorFactory.YetkilerValidator().ValidateYetkiSil(yetkiid);
        //    if (errors.Length != 0)
        //        return ApiResponseFactory.Warning<bool>(errors);
        //    var model = await _yetkilerService.YetkiSil(yetkiid);
        //    return ApiResponse(model);
        //}


    }
}


