using ERP.Application.DTOs.KullaniciDTOs;
using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Kullanici;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{

    public interface IKullaniciService : IDisposable
    {
        Task<List<KademeDTO>> KullaniciGorevler(int kullaniciId);

        Task<KullaniciToken> GirisYap(KullaniciGirisDTO kullaniciGirisDTO);

        Task<KullaniciDTO> KullaniciEkle(KullaniciDTO kullaniciEkleDTO);

        Task<bool> KullaniciGuncelle(KullaniciDTO kullaniciGuncelleDTO);

        Task<bool> KullaniciSil(int id);

        Task<KullaniciDTO> KullaniciGetir(int id);

        Task<PagedResult<KullaniciDTO>> KullaniciListele(KullaniciAraDTO kullaniciAraDTO);

        Task<bool> SifremiUnuttum(KullaniciDTO sifremiUnuttumDTO);

        Task<bool> SifreDegistir(KullaniciDTO sifreDegistirDTO);
    }
}
