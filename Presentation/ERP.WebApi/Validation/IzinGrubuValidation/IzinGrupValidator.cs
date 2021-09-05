using ERP.Application.DTOs.IzinGrupDTOs;
using ERP.WebApi.Validation.IzinGrubuValidation.IzinGrup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IzinGrubuValidation
{
    public class IzinGrupValidator : IIzinGrupValidator
    {
        public string[] ValidateIzinGrupEkle(IzinGrupEkleDTO izinGrupEkleDTO)
        {
            return new IzinGrupEkleValidator().ValidateModel(izinGrupEkleDTO);

        }

        public string[] ValidateIzinGrupGuncelle(IzinGrupGuncelleDTO izinGrupGuncelleDTO)
        {
            return new IzinGrupGuncelleValidator().ValidateModel(izinGrupGuncelleDTO);

        }

        public string[] ValidateIzinGrupSil(int id)
        {
            return new IzinGrupSilValidator().ValidateModel(id);

        }
    }
}
