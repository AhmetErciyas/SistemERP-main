using ERP.Application.DTOs.Finans;
using ERP.Application.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FirmaController : BaseController
    {
        private readonly IFinansService _finansService;

        public FirmaController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IFinansService finansService) : base(notifications, mediator)
        {
            _finansService = finansService;
        }

        #region Firma Tür

        /// <summary>
        /// Id'si verilen FirmaTur getirir.
        /// </summary>
        /// <returns></returns>
        [HttpGet("firma-tur-getir/{id}")]
        public async Task<ApiResponse<FirmaTurDTO>> FirmaTurGetir(byte id)
        {
            var FirmaTurListe = await _finansService.FirmaTurGetir(id);
            return ApiResponse(FirmaTurListe);
        }

        /// <summary>
        /// FirmaTur listesi getirir.
        /// </summary>
        /// <returns></returns>
        [HttpGet("firma-tur-listele")]
        public async Task<ApiResponse<IEnumerable<FirmaTurDTO>>> FirmaTurListele()
        {
            var FirmaTurListe = await _finansService.FirmaTurListele();
            return ApiResponse(FirmaTurListe);
        }
        #endregion
    }
}
