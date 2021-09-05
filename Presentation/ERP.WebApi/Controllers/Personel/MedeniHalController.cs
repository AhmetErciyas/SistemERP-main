using ERP.Core.Enums;
using ERP.Core.Extensions;
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
    public class MedeniHalController : ControllerBase
    {
        [HttpGet("getir")]
        public List<EnumValue> getir()
        {
            var model = EnumExtensions.GetValues<MedeniHal>();
            return model;
        }
    }
}
