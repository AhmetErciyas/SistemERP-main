using ERP.Application.DTOs.YetkiGruplariDTOs;
using ERP.WebApi.Validation.YetkiGruplariValidation.YetkiGruplari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariValidation
{
    public class YetkiGruplariValidator : IYetkiGruplariValidator
    {
        public string[] ValidateYetkiGrupEkle(YetkiGrupEkleDTO yetkiGrupEkleDTO)
        {
            return new YetkiGruplariEkleValidator().ValidateModel(yetkiGrupEkleDTO);

        }

        public string[] ValidateYetkiGrupGuncelle(YetkiGrupGuncelleDTO yetkiGrupGuncelleDTO)
        {
            return new YetkiGruplariGuncelleValidator().ValidateModel(yetkiGrupGuncelleDTO);

        }

        public string[] ValidateYetkiGrupSil(int id)
        {
            return new YetkiGruplariSilValidator().ValidateModel(id);

        }
    }
}
