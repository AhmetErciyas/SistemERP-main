using ERP.Application.DTOs.YetkilerDTOs;
using ERP.WebApi.Validation.YetkilerValidation.Yetkiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkilerValidation
{
    public class YetkilerValidator : IYetkilerValidator
    {
        public string[] ValidateYetkiEkle(YetkiEkleDTO yetkiEkleDTO)
        {
            return new 
                YetkiEkleValidator().ValidateModel(yetkiEkleDTO);
        }

        public string[] ValidateYetkiGuncelle(YetkiGuncelleDTO yetkiGuncelleDTO)
        {
            return new YetkiGuncelleValidator().ValidateModel(yetkiGuncelleDTO);
        }

        public string[] ValidateYetkiSil(int id)
        {
            return new YetkiSilValidator().ValidateModel(id);
        }
    }
}
