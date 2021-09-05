using ERP.Application.DTOs.YetkiGruplariDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariValidation
{
    public interface IYetkiGruplariValidator
    {
        string[] ValidateYetkiGrupEkle(YetkiGrupEkleDTO yetkiGrupEkleDTO);
        string[] ValidateYetkiGrupSil(int id);
        string[] ValidateYetkiGrupGuncelle(YetkiGrupGuncelleDTO yetkiGrupGuncelleDTO);
    }
}
