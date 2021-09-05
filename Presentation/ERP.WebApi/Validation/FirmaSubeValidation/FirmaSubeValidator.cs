using ERP.Application.DTOs.FirmaSubeDTOs;
using ERP.WebApi.Validation.FirmaSubeValidation.FirmaSube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.WebApi.Validation.FirmaSubeValidation
{
    public class FirmaSubeValidator : IFirmaSubeValidator
    {
        public string[] ValidateFirmaSubeAra(FirmaSubeAraDTO firmasubeAraDTO)
        {
            return new FirmaSubeAraValidator().ValidateModel(firmasubeAraDTO);

        }

        public string[] ValidateFirmaSubeEkle(FirmaSubeEkleDTO firmasubeEkleDTO)
        {
            return new FirmaSubeEkleValidator().ValidateModel(firmasubeEkleDTO);

        }

        public string[] ValidateFirmaSubeGetir(int id)
        {
            return new FirmaSubeGetirValidator().ValidateModel(id);

        }

        public string[] ValidateFirmaSubeGuncelle(FirmaSubeGuncelleDTO firmasubeGuncelleDTO)
        {
            return new FirmaSubeGuncelleValidator().ValidateModel(firmasubeGuncelleDTO);

        }
    }
}
