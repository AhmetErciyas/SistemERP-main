using ERP.Application.DTOs.AskerlikDurumDTOs;
using ERP.Application.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using ERP.Identity;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers.Personel
{
    [Authorize]
    [Route("Personel/[controller]")]
    [ApiController]
    public class AskerlikDurumController : BaseController
    {
        private readonly IPersonelService _personelService;

        public AskerlikDurumController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IPersonelService askerlikDurumService) : base(notifications, mediator)
        {
            _personelService = askerlikDurumService;
        }
        [HttpGet("getir")]
        public async Task<ApiResponse<List<AskerlikDurumDTO>>> Getir()
        {
            var model = await _personelService.AskerlikDurumlariGetir();
            return ApiResponse(model);
        }
    }
}
