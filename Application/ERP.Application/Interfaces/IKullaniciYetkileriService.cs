using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{
    public interface IKullaniciYetkileriService
    {
        Task<KullaniciYetkiDTO> KullaniciYetkiEkle(KullaniciYetkiEkleDTO kullaniciYetkiEkleDTO);
        Task<KullaniciYetkiDTO> KullaniciYetkiGuncelle(KullaniciYetkiGuncelleDTO kullaniciYetkiGuncelleDTO);
        Task<bool> KullaniciYetkiSil(int kullaniciYetkiId);
        Task<List<KullaniciYetkiDTO>> KullaniciYetkileriGetir();
    }
}
