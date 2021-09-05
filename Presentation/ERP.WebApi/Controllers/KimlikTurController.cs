using ERP.Core.Enums;
using ERP.Core.Extensions;
using ERP.Domain.Core.Response;
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
    public class KimlikTurController : ControllerBase
    {
        [HttpGet("kimliktur-getir")]
        public List<EnumValue> GetKimlikTurler()
        {
            var model = EnumExtensions.GetValues<KimlikTur>();
            return model;
        }
    }
}
