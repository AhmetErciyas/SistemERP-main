using ERP.Application;
using ERP.Application.DTOs;
using ERP.Application.DTOs.OrganizasyonDTOs;
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
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class OrganizasyonController : BaseController
    {
        private readonly IOrganizasyonService _organizasyonService;

        public OrganizasyonController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IOrganizasyonService organizasyonService) : base(notifications, mediator)
        {
            _organizasyonService = organizasyonService;
        }

        #region Departman

        [HttpPost("departman-ekle")]
        public async Task<ApiResponse<DepartmanDTO>> DepartmanEkle(DepartmanEkleDTO departmanEKleDTO)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateDepartmanEkle(departmanEKleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<DepartmanDTO>(errors);
            var model = await _organizasyonService.DepartmanEkle(departmanEKleDTO);
            return ApiResponse(model);
        }

        [HttpPost("departman-guncelle")]
        public async Task<ApiResponse<DepartmanDTO>> DepartmanGuncelle(DepartmanDTO departmanDTO)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateDepartmanGuncelle(departmanDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<DepartmanDTO>(errors);
            var model = await _organizasyonService.DepartmanGuncelle(departmanDTO);
            return ApiResponse(model);
        }

        [HttpPost("departman-sil")]
        public async Task<ApiResponse<bool>> DepartmanSil(int departmanid)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateDepartmanGetir(departmanid);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _organizasyonService.DepartmanSil(departmanid);
            return ApiResponse(model);
        }

        [HttpPost("departman-ara")]
        public async Task<ApiResponse<List<DepartmanDTO>>> DepartmanAra(DepartmanDTO departmanDTO)
        {
            /*
            var errors = ValidatorFactory.GetOrganizasyonValidator().ValidateOrganizasyon(OrganizasyonDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<OrganizasyonDTO>(errors);
            */
            var model = await _organizasyonService.DepartmanAra(departmanDTO);
            return ApiResponse(model);
        }

        #endregion

        #region Unvan

        [HttpPost("unvan-ekle")]
        public async Task<ApiResponse<UnvanDTO>> UnvanEkle(UnvanEkleDTO unvanEkleDTO)
        {

            var errors = ValidatorFactory.OrganizasyonValidator().ValidateUnvanEkle(unvanEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<UnvanDTO>(errors);

            var model = await _organizasyonService.UnvanEkle(unvanEkleDTO);
            return ApiResponse(model);
        }

        [HttpPost("unvan-guncelle")]
        public async Task<ApiResponse<UnvanDTO>> UnvanGuncelle(UnvanDTO unvanDTO)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateUnvanGuncelle(unvanDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<UnvanDTO>(errors);
            var model = await _organizasyonService.UnvanGuncelle(unvanDTO);
            return ApiResponse(model);
        }

        [HttpPost("unvan-sil")]
        public async Task<ApiResponse<bool>> UnvanSil(int unvanid)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateDepartmanGetir(unvanid);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _organizasyonService.UnvanSil(unvanid);
            return ApiResponse(model);
        }

        [HttpPost("unvan-ara")]
        public async Task<ApiResponse<List<UnvanDTO>>> UnvanAra(UnvanDTO unvanDTO)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateUnvanAra(unvanDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<List<UnvanDTO>> (errors);
            var model = await _organizasyonService.UnvanAra(unvanDTO);
            return ApiResponse(model);
        }

        #endregion

        #region Kademe

        [HttpPost("kademe-ekle")]
        public async Task<ApiResponse<KademeDTO>> KademeEkle(KademeEkleDTO kademeEkleDTO)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateKademeEkle(kademeEkleDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<KademeDTO>(errors);
            var model = await _organizasyonService.KademeEkle(kademeEkleDTO);
            return ApiResponse(model);
        }

        [HttpPost("kademe-guncelle")]
        public async Task<ApiResponse<KademeDTO>> KademeGuncelle(KademeGuncelleDTO kademeDTO)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateKademeGuncelle(kademeDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<KademeDTO>(errors);
            var model = await _organizasyonService.KademeGuncelle(kademeDTO);
            return ApiResponse(model);
        }

        [HttpPost("kademe-sil")]
        public async Task<ApiResponse<bool>> KademeSil(int kademeid)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateDepartmanGetir(kademeid);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);
            var model = await _organizasyonService.KademeSil(kademeid);
            return ApiResponse(model);
        }

        [HttpPost("kademe-ara")]
        public async Task<ApiResponse<List<KademeDTO>>> KademeAra(KademeDTO kademeDTO)
        {
            var errors = ValidatorFactory.OrganizasyonValidator().ValidateKademeAra(kademeDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<List<KademeDTO>>( errors);
            var model = await _organizasyonService.KademeAra(kademeDTO);
            return ApiResponse(model);
        }

        #endregion
    }
}
