using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
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

namespace ERP.WebApi.Controllers.Personel
{
    [Route("Personel/[controller]")]
    [ApiController]
    public class IstenAyrilmaNedenController : BaseController
    {
        private readonly IPersonelService _personelService;

        public IstenAyrilmaNedenController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IPersonelService personelService) : base(notifications, mediator)
        {
            _personelService = personelService;
        }
        [HttpPost("ekle")]
        public async Task<ApiResponse<IstenAyrilmaNedenleriDTO>> Ekle(IstenAyrilmaNedenleriEkleDTO istenAyrilmaNedenleriEkleDTO)
        {

            var errors = ValidatorFactory.IstenAyrilmaNedenleriValidator().ValidateIstenAyrilmaNedenEkle(istenAyrilmaNedenleriEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<IstenAyrilmaNedenleriDTO>(errors);
            var model = await _personelService.IstenAyrilmaNedenleriEkle(istenAyrilmaNedenleriEkleDTO);
            return ApiResponse(model);
        }

        [HttpPost("guncelle")]
        public async Task<ApiResponse<IstenAyrilmaNedenleriDTO>> Guncelle(IstenAyrilmaNedenleriGuncelleDTO istenAyrilmaNedenleriGuncelleDTO)
        {

            var errors = ValidatorFactory.IstenAyrilmaNedenleriValidator().ValidateIstenAyrilmaNedenGuncelle(istenAyrilmaNedenleriGuncelleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<IstenAyrilmaNedenleriDTO>(errors);
            var model = await _personelService.IstenAyrilmaNedenGuncelle(istenAyrilmaNedenleriGuncelleDTO);
            return ApiResponse(model);
        }

        [HttpPost("sil")]
        public async Task<ApiResponse<bool>> Sil(int istenAyrilmaNedenId)
        {

            var errors = ValidatorFactory.IstenAyrilmaNedenleriValidator().ValidateIstenAyrilmaNedenSil(istenAyrilmaNedenId);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _personelService.IstenAyrilmaNedenSil(istenAyrilmaNedenId);
            return ApiResponse(model);
        }

        [HttpGet("getir")]
        public async Task<ApiResponse<List<IstenAyrilmaNedenleriDTO>>> Getir()
        {
            
            var model = await _personelService.IstenAyrilmaNedenleriGetir();
            return ApiResponse(model);
        }
    }
}
