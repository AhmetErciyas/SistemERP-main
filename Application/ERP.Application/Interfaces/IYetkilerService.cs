using ERP.Application.DTOs.YetkilerDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{
    public interface IYetkilerService
    {
        //Task<YetkiDTO> YetkiEkle(YetkiEkleDTO yetkiEkleDTO);
        //Task<YetkiDTO> YetkiGuncelle(YetkiGuncelleDTO yetkiGuncelleDTO);
        //Task<bool> YetkiSil(int yetkiId);
        Task<List<YetkiDTO>> YetkileriGetir();
    }
}
