using ERP.Application.DTOs.Finans;
using ERP.Application.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FinansController : BaseController
    {
        private readonly IFinansService _finansService;

        public FinansController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IFinansService finansService) : base(notifications, mediator)
        {
            _finansService = finansService;
        }

        [AllowAnonymous]
        [HttpPost("firma-ekle")]
        public async Task<ApiResponse<FinansFirmaDTO>> FirmaEkle(FinansFirmaEkleDTO finansFirmaDTO)
        {
            /*
             * TODO : fluen validation eklenecek
             * */
            var model = await _finansService.FirmaEkle(finansFirmaDTO);
            return ApiResponse(model);
        }
    }
}
