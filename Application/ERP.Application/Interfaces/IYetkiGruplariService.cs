using ERP.Application.DTOs.YetkiGruplariDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{
    public interface IYetkiGruplariService
    {
        Task<YetkiGrupDTO> YetkiGrupEkle(YetkiGrupEkleDTO yetkiGrupEkleDTO);
        Task<YetkiGrupDTO> YetkiGrupGuncelle(YetkiGrupGuncelleDTO yetkiGrupGuncelleDTO);
        Task<bool> YetkiGrupSil(int yetkiGrupId);
        Task<List<YetkiGrupDTO>> YetkiGruplariGetir();
    }
}
