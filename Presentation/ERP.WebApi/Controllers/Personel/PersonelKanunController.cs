using ERP.Application.DTOs.PersonelKanun;
using ERP.Application.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using ERP.WebApi.Validation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers.Personel
{
    [Route("Personel/[controller]")]
    public class PersonelKanunController : BaseController
    {
        private readonly IPersonelService _personelService;

        public PersonelKanunController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IPersonelService personelService) : base(notifications, mediator)
        {
            _personelService = personelService;
        }
        [HttpPost("ekle")]
        public async Task<ApiResponse<PersonelKanunDTO>> Ekle(PersonelKanunEkleDTO personelKanunEkleDTO)
        {

            var errors = ValidatorFactory.PersonelKanunValidator().ValidatePersonelKanunEkle(personelKanunEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PersonelKanunDTO>(errors);
            var model = await _personelService.PersonelKanunEkle(personelKanunEkleDTO);
            return ApiResponse(model);
        }

        [HttpPost("guncelle")]
        public async Task<ApiResponse<PersonelKanunDTO>> Guncelle(PersonelKanunGuncelleDTO personelKanunGuncelleDTO)
        {

            var errors = ValidatorFactory.PersonelKanunValidator().ValidatePersonelKanunGuncelle(personelKanunGuncelleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PersonelKanunDTO>(errors);
            var model = await _personelService.PersonelKanunGuncelle(personelKanunGuncelleDTO);
            return ApiResponse(model);
        }

        [HttpPost("sil")]
        public async Task<ApiResponse<bool>> Sil(int personelKanunId)
        {

            var errors = ValidatorFactory.PersonelKanunValidator().ValidatePersonelKanunSil(personelKanunId);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _personelService.PersonelKanunSil(personelKanunId);
            return ApiResponse(model);
        }

        [HttpGet("getir")]
        public async Task<ApiResponse<List<PersonelKanunDTO>>> Getir()
        {

            var model = await _personelService.PersonelKanunlariGetir();
            return ApiResponse(model);
        }
    }
}
