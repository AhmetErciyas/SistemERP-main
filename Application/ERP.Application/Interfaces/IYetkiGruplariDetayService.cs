using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using ERP.Application.DTOs.YetkiGruplariDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{
    public interface  IYetkiGruplariDetayService
    {
        Task<YetkiGrupDetayDTO> YetkiGrupDetayEkle(YetkiGrupDetayEkleDTO yetkiGrupDetayEkleDTO);
        Task<YetkiGrupDetayDTO> YetkiGrupDetayGuncelle(YetkiGrupDetayGuncelleDTO yetkiGrupDetayGuncelleDTO);
        Task<bool> YetkiGrupDetaySil(int yetkiGrupDetayId);
        Task<List<YetkiGrupDetayDTO>> YetkiGrupDetaylariGetir();
    }
}
