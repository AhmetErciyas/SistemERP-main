using ERP.Application.DTOs.FirmaSubeDTOs;
using ERP.Core.PageSortFilter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.Application.Interfaces
{
    public interface IFirmaSubeService
    {
        Task<FirmaSubeDTO> FirmaSubeEkle(FirmaSubeEkleDTO personelEkleDTO);
        Task<PagedResult<FirmaSubeDTO>> FirmaSubeAra(FirmaSubeAraDTO personelAraDTO);
        Task<FirmaSubeDTO> FirmaSubeGetir(int id);
        Task<FirmaSubeDTO> FirmaSubeGuncelle(FirmaSubeGuncelleDTO personelGuncelleDTO);
        Task<bool> FirmaSubeSil(int id);
    }
}
