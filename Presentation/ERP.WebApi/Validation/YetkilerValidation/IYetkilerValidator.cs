using ERP.Application.DTOs.YetkilerDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkilerValidation
{
    public interface IYetkilerValidator
    {
        string[] ValidateYetkiEkle(YetkiEkleDTO yetkiEkleDTO);
        string[] ValidateYetkiSil(int id);
        string[] ValidateYetkiGuncelle(YetkiGuncelleDTO yetkiGuncelleDTO);
    }
}
