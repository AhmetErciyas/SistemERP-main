using ERP.Application.DTOs.FirmaSubeDTOs;
using ERP.Application.Interfaces;
using ERP.Core.PageSortFilter;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using ERP.WebApi.Validation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaSubeController : BaseController
    {
        private readonly IFirmaSubeService _firmasubeService;

        public FirmaSubeController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IFirmaSubeService firmasubeService) : base(notifications, mediator)
        {
            _firmasubeService = firmasubeService;
        }

        #region Personel  
        [Authorize(Roles="GetKullaniciList")]
        [HttpPost("firmasube-ekle")]
        public async Task<ApiResponse<FirmaSubeDTO>> FirmaSubeEkle(FirmaSubeEkleDTO firmasubeEkleDTO)
        {
            var errors = ValidatorFactory.FirmaSubeValidator().ValidateFirmaSubeEkle(firmasubeEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<FirmaSubeDTO>(errors);

            var model = await _firmasubeService.FirmaSubeEkle(firmasubeEkleDTO);
            return ApiResponse(model);
        }


        [HttpGet("firmasube-getir/{id}")]
        public async Task<ApiResponse<FirmaSubeDTO>> FirmaSubeGetir(int id)
        {
            var errors = ValidatorFactory.FirmaSubeValidator().ValidateFirmaSubeGetir(id);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<FirmaSubeDTO>(errors);

            var model = await _firmasubeService.FirmaSubeGetir(id);
            return ApiResponse(model);
        }

        [HttpPost("firmasube-ara")]
        public async Task<ApiResponse<PagedResult<FirmaSubeDTO>>> FirmaSubeAra(FirmaSubeAraDTO firmasubeAraDTO)
        {
            var errors = ValidatorFactory.FirmaSubeValidator().ValidateFirmaSubeAra(firmasubeAraDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PagedResult<FirmaSubeDTO>>(errors);

            var model = await _firmasubeService.FirmaSubeAra(firmasubeAraDTO);
            return ApiResponse(model);
        }

        [HttpPost("firmasube-guncelle")]
        public async Task<ApiResponse<FirmaSubeDTO>> FirmaSubeGuncelleGuncelle(FirmaSubeGuncelleDTO firmasubeDTO)
        {
            var errors = ValidatorFactory.FirmaSubeValidator().ValidateFirmaSubeGuncelle(firmasubeDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<FirmaSubeDTO>(errors);

            var model = await _firmasubeService.FirmaSubeGuncelle(firmasubeDTO);
            return ApiResponse(model);
        }

        [HttpPost("firmasube-sil/{id}")]
        public async Task<ApiResponse<bool>> FirmaSubelSil(int id)
        {
            var errors = ValidatorFactory.FirmaSubeValidator().ValidateFirmaSubeGetir(id);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);

            var model = await _firmasubeService.FirmaSubeSil(id);
            return ApiResponse(model);
        }
        #endregion
    }
}
