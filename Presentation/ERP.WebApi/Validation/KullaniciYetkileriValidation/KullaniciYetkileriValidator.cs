using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using ERP.WebApi.Validation.KullaniciYetkileriValidation.KullaniciYetkileri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.KullaniciYetkileriValidation
{
    public class KullaniciYetkileriValidator : IKullaniciYetkileriValidator
    {
        public string[] ValidateKullaniciYetkiEkle(KullaniciYetkiEkleDTO kullaniciYetkiEkleDTO)
        {
            return new KullaniciYetkiEkleValidator().ValidateModel(kullaniciYetkiEkleDTO);
        }

        public string[] ValidateKullaniciYetkiGuncelle(KullaniciYetkiGuncelleDTO kullaniciYetkiGuncelleDTO)
        {
            return new KullaniciYetkiGuncelleValidator().ValidateModel(kullaniciYetkiGuncelleDTO);

        }

        public string[] ValidateKullaniciYetkiSil(int id)
        {
            return new KullaniciYetkiSilValidator().ValidateModel(id);

        }
    }
}
