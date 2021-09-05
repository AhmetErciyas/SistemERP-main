using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariDetayValidation
{
    public interface IYetkiGruplariDetayValidator
    {
        string[] ValidateYetkiGruplariDetayEkle(YetkiGrupDetayEkleDTO yetkiGrupDetayEkleDTO);
        string[] ValidateYetkiGruplariDetaySil(int id);
        string[] ValidateYetkiGruplariDetayGuncelle(YetkiGrupDetayGuncelleDTO yetkiGrupDetayGuncelleDTO);
    }
}
