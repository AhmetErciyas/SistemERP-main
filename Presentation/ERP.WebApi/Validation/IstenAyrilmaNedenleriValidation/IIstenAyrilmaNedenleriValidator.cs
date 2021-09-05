using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IstenAyrilmaNedenleriValidation
{
    public interface IIstenAyrilmaNedenleriValidator
    {
        string[] ValidateIstenAyrilmaNedenEkle(IstenAyrilmaNedenleriEkleDTO istenAyrilmaNedenleriEkleDTO);
        string[] ValidateIstenAyrilmaNedenSil(int id);
        string[] ValidateIstenAyrilmaNedenGuncelle(IstenAyrilmaNedenleriGuncelleDTO istenAyrilmaNedenleriGuncelleDTO);
    }
}
