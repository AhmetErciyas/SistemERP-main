using ERP.Application.DTOs.KullaniciDTOs;
using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.KullaniciYetkileriValidation
{
    public interface IKullaniciYetkileriValidator
    {
        string[] ValidateKullaniciYetkiEkle(KullaniciYetkiEkleDTO kullaniciYetkiEkleDTO);
        string[] ValidateKullaniciYetkiSil(int id);
        string[] ValidateKullaniciYetkiGuncelle(KullaniciYetkiGuncelleDTO kullaniciYetkiGuncelleDTO);
    }
}
