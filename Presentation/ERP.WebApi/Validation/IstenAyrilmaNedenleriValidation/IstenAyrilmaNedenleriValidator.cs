using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using ERP.WebApi.Validation.IstenAyrilmaNedenleriValidation.IstenAyrilmaNedenleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IstenAyrilmaNedenleriValidation
{
    public class IstenAyrilmaNedenleriValidator : IIstenAyrilmaNedenleriValidator
    {
        public string[] ValidateIstenAyrilmaNedenEkle(IstenAyrilmaNedenleriEkleDTO istenAyrilmaNedenleriEkleDTO)
        {
            return new IstenAyrilmaNedenEkleValidator().ValidateModel(istenAyrilmaNedenleriEkleDTO);
        }

        public string[] ValidateIstenAyrilmaNedenGuncelle(IstenAyrilmaNedenleriGuncelleDTO istenAyrilmaNedenleriGuncelleDTO)
        {
            return new IstenAyrilmaNedenGuncelleValidator().ValidateModel(istenAyrilmaNedenleriGuncelleDTO);
        }

        public string[] ValidateIstenAyrilmaNedenSil(int id)
        {
            return new IstenAyrilmaNedenSilValidator().ValidateModel(id);
        }
    }
}
