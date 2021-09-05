using ERP.Application.DTOs.Finans;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{
    public interface IFinansService : IDisposable
    {
        Task<FinansFirmaDTO> FirmaEkle(FinansFirmaEkleDTO finansFirmaDTO);

        Task<IEnumerable<FirmaTurDTO>> FirmaTurListele();

        Task<FirmaTurDTO> FirmaTurGetir(byte id);
    }
}
