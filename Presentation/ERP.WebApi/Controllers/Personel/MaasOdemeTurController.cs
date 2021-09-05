using ERP.Core.Enums;
using ERP.Core.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
    [Route("Personel/[controller]")]
    [ApiController]
    public class MaasOdemeTurController : ControllerBase
    {
        [HttpGet("getir")]
        public List<EnumValue> Getir()
        {
            var model = EnumExtensions.GetValues<MaasOdemeTur>();
            return model;
        }
    }
}
