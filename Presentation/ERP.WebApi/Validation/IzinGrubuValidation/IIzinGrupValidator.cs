using ERP.Application.DTOs.IzinGrupDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IzinGrubuValidation
{
    public interface IIzinGrupValidator
    {
        string[] ValidateIzinGrupEkle(IzinGrupEkleDTO izinGrupEkleDTO);
        string[] ValidateIzinGrupSil(int id);
        string[] ValidateIzinGrupGuncelle(IzinGrupGuncelleDTO izinGrupGuncelleDTO);
    }
}
