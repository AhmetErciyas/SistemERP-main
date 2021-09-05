using ERP.Application.DTOs.SigortaTurDTOs;
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
    public class SigortaTurController : BaseController
    {
        private readonly IPersonelService _personelService;

        public SigortaTurController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IPersonelService personelService) : base(notifications, mediator)
        {
            _personelService = personelService;
        }
        [HttpGet("getir")]
        public async Task<ApiResponse<List<SigortaTurDTO>>> Getir()
        {

            var model = await _personelService.SigortaTurleriGetir();
            return ApiResponse(model);
        }
    }
}
