using ERP.Application;
using ERP.Application.DTOs;
using ERP.Application.DTOs.PersonelDTOs;
using ERP.Application.Interfaces;
using ERP.Core.PageSortFilter;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using ERP.WebApi.Validation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PersonelController : BaseController
    {
        private readonly IPersonelService _personelService;

        public PersonelController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IPersonelService personelService) : base(notifications, mediator)
        {
            _personelService = personelService;
        }

        #region Personel

        [HttpPost("personel-ekle")]
        public async Task<ApiResponse<PersonelDTO>> PersonelEkle(PersonelEkleDTO personelEkleDTO)
        {
            var errors = ValidatorFactory.PersonelValidator().ValidatePersonelEkle(personelEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PersonelDTO>(errors);
            
            var model = await _personelService.PersonelEkle(personelEkleDTO);
            return ApiResponse(model);
        }

        [HttpGet("personel-getir/{id}")]
        public async Task<ApiResponse<PersonelDTO>> PersonelGetir(int id)
        {
            var errors = ValidatorFactory.PersonelValidator().ValidatePersonelGetir(id);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PersonelDTO>(errors);

            var model = await _personelService.PersonelGetir(id);
            return ApiResponse(model);
        }

        [HttpPost("personel-ara")]
        public async Task<ApiResponse<List<PersonelDTO>>> PersonelAra(PersonelAraDTO personelAraDTO)
        {
            var errors = ValidatorFactory.PersonelValidator().ValidatePersonelAra(personelAraDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<List<PersonelDTO>>(errors);

            var model = await _personelService.PersonelAra(personelAraDTO);
            return ApiResponse(model);
        }

        [HttpPost("personel-guncelle")]
        public async Task<ApiResponse<PersonelDTO>> PersonelGuncelle(PersonelGuncelleDTO personelDTO)
        {
            var errors = ValidatorFactory.PersonelValidator().ValidatePersonelGuncelle(personelDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PersonelDTO>(errors);

            var model = await _personelService.PersonelGuncelle(personelDTO);
            return ApiResponse(model);
        }

        [HttpPost("personel-sil/{id}")]
        public async Task<ApiResponse<bool>> PersonelSil(int id)
        {
            var errors = ValidatorFactory.PersonelValidator().ValidatePersonelGetir(id);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);

            var model = await _personelService.PersonelSil(id);
            return ApiResponse(model);
        }
        #endregion

        #region PersonelLookupTables

        #endregion
    }
}
