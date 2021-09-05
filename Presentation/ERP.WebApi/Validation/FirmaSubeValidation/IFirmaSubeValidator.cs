using ERP.Application.DTOs.FirmaSubeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.WebApi.Validation.FirmaSubeValidation
{
    public interface IFirmaSubeValidator
    {
        string[] ValidateFirmaSubeEkle(FirmaSubeEkleDTO firmasubeEkleDTO);
        string[] ValidateFirmaSubeGetir(int id);
        string[] ValidateFirmaSubeAra(FirmaSubeAraDTO firmasubeAraDTO);
        string[] ValidateFirmaSubeGuncelle(FirmaSubeGuncelleDTO firmasubeGuncelleDTO);
    }
}
