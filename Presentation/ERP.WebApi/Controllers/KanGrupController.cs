using ERP.Core.Enums;
using ERP.Core.Extensions;
using ERP.Data.Entities;
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
    public class KanGrupController : ControllerBase
    {
        [HttpGet("kangrup-getir")]
        public List<EnumValue> GetKanGruplari()
        {
            
            var myEnumDescriptions = from KanGrup n in Enum.GetValues(typeof(KanGrup))
                                     select new EnumValue{ Value = (int)n, Name = EnumerationExtension.Description(n) };
            return myEnumDescriptions.ToList();
        }
    }
}
