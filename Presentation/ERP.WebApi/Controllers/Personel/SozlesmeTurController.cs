
using ERP.Application.DTOs.SozlesmeTurDTOs;
using ERP.Application.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
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
    public class SozlesmeTurController : BaseController
    {
        private readonly IPersonelService _personelService;

        public SozlesmeTurController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           IPersonelService personelService) : base(notifications, mediator)
        {
            _personelService = personelService;
        }
        [HttpGet("getir")]
        public async Task<ApiResponse<List<SozlesmeTurDTO>>> Getir()
        {
            var model = await _personelService.SozlesmeTurleriGetir();
            return ApiResponse(model);
        }
    }
}

