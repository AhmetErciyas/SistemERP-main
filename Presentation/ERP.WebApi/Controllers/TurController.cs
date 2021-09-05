using ERP.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TurController : ControllerBase
    {
        [HttpGet("getir/{id}")]
        public List<KeyValuePair<string, int>> getir(string id)
        {
            Type t = Type.GetType(id);
            var enm =  Activator.CreateInstance(t);
            var model = EnumExtensions.GetEnumValuesAndDescriptions<string>();
            return model;
        }
    }
}
