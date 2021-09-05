using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using ERP.WebApi.Validation.YetkiGruplariDetayValidation.YetkiGruplariDetay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariDetayValidation
{
    public class YetkiGruplariDetayValidator : IYetkiGruplariDetayValidator
    {
        public string[] ValidateYetkiGruplariDetayEkle(YetkiGrupDetayEkleDTO yetkiGrupDetayEkleDTO)
        {
            return new YetkiGruplariDetayEkleValidator().ValidateModel(yetkiGrupDetayEkleDTO);

        }

        public string[] ValidateYetkiGruplariDetayGuncelle(YetkiGrupDetayGuncelleDTO yetkiGrupDetayGuncelleDTO)
        {
            return new YetkiGruplariDetayGuncelleValidator().ValidateModel(yetkiGrupDetayGuncelleDTO);

        }

        public string[] ValidateYetkiGruplariDetaySil(int id)
        {
            return new YetkiGruplariDetaySilValidator().ValidateModel(id);

        }
    }
}
