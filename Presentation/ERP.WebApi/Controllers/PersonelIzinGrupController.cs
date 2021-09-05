using ERP.Application.DTOs.IzinGrupDTOs;
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
    public class PersonelIzinGrupController : BaseController
    {
        private readonly IPersonelService _personelService;

        public PersonelIzinGrupController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IPersonelService personelService) : base(notifications, mediator)
        {
            _personelService = personelService;
        }
        [HttpPost("izingrup-ekle")]
        public async Task<ApiResponse<IzinGrupDTO>> IzinGrupEkle(IzinGrupEkleDTO izinGrupEkleDTO)
        {
          
            var errors = ValidatorFactory.IzinGrupValidator().ValidateIzinGrupEkle(izinGrupEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<IzinGrupDTO>(errors);
            var model = await _personelService.IzinGrupEkle(izinGrupEkleDTO);
            return ApiResponse(model);
        }

        [HttpPost("izingrup-guncelle")]
        public async Task<ApiResponse<IzinGrupDTO>> IzinGrupGuncelle(IzinGrupGuncelleDTO izinGrupGuncelleDTO)
        {
            var errors = ValidatorFactory.IzinGrupValidator().ValidateIzinGrupGuncelle(izinGrupGuncelleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<IzinGrupDTO>(errors);
            var model = await _personelService.IzinGrupGuncelle(izinGrupGuncelleDTO);
            return ApiResponse(model);
        }

        [HttpPost("izingrup-sil")]
        public async Task<ApiResponse<bool>> IzinGrupSil(int izinGrupid)
        {
           var errors = ValidatorFactory.IzinGrupValidator().ValidateIzinGrupSil(izinGrupid);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _personelService.IzinGrupSil(izinGrupid);
            return ApiResponse(model);
        }

        [HttpPost("izingrup-getir")]
        public async Task<ApiResponse<List<IzinGrupDTO>>> IzinGruplariGetir()
        {
            //var errors = ValidatorFactory.OrganizasyonValidator().ValidateKademeAra(izinGrupDTO);
            //if (errors.Length != 0)
            //    return ApiResponseFactory.Warning<List<IzinGrupDTO>>(errors);
            var model = await _personelService.IzinGruplariGetir();
            return ApiResponse(model);
        }
    }
}
