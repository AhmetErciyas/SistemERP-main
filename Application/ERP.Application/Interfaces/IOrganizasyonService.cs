using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Core.PageSortFilter;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{
    public interface IOrganizasyonService : IDisposable
    {
        Task<DepartmanDTO> DepartmanEkle(DepartmanEkleDTO departmanEKleDTO);
        Task<DepartmanDTO> DepartmanGuncelle(DepartmanDTO departmanDTO);
        Task<bool> DepartmanSil(int departmanId);
        Task<List<DepartmanDTO>> DepartmanAra(DepartmanDTO departmanDTO);

        Task<UnvanDTO> UnvanEkle(UnvanEkleDTO unvanEkleDTO);
        Task<UnvanDTO> UnvanGuncelle(UnvanDTO unvanDTO);
        Task<bool> UnvanSil(int unvanId);
        Task<List<UnvanDTO>> UnvanAra(UnvanDTO unvanDTO);

        Task<KademeDTO> KademeEkle(KademeEkleDTO kademeDTO);
        Task<KademeDTO> KademeGuncelle(KademeGuncelleDTO kademeGuncelleDTO);
        Task<bool> KademeSil(int kademeId);
        Task<List<KademeDTO>> KademeAra(KademeDTO kademeDTO);
    }
}
