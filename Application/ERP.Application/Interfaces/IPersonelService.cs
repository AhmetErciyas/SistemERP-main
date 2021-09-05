using ERP.Application.DTOs.AskerlikDurumDTOs;
using ERP.Application.DTOs.EngellilikDurumDTOs;
using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using ERP.Application.DTOs.IzinGrupDTOs;
using ERP.Application.DTOs.OgrenimDurumDTOs;
using ERP.Application.DTOs.PersonelDTOs;
using ERP.Application.DTOs.PersonelKanun;
using ERP.Application.DTOs.SigortaTurDTOs;
using ERP.Application.DTOs.SozlesmeTurDTOs;
using ERP.Core.PageSortFilter;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces
{
    public interface IPersonelService : IDisposable
    {
        Task<PersonelDTO> PersonelEkle(PersonelEkleDTO personelEkleDTO);
        Task<List<PersonelDTO>> PersonelAra(PersonelAraDTO personelAraDTO);
        Task<PersonelDTO> PersonelGetir(int id);
        Task<PersonelDTO> PersonelGuncelle(PersonelGuncelleDTO personelGuncelleDTO);
        Task<bool> PersonelSil(int id);
        Task<List<AskerlikDurumDTO>> AskerlikDurumlariGetir();
        Task<PersonelKanunDTO> PersonelKanunEkle(PersonelKanunEkleDTO personelKanunEkleDTO);
        Task<PersonelKanunDTO> PersonelKanunGuncelle(PersonelKanunGuncelleDTO personelKanunGuncelleDTO);
        Task<bool> PersonelKanunSil(int personelKanunId);
        Task<List<PersonelKanunDTO>> PersonelKanunlariGetir();
        Task<List<EngellilikDurumDto>> EngellilikDurumlariGetir();
        Task<IstenAyrilmaNedenleriDTO> IstenAyrilmaNedenleriEkle(IstenAyrilmaNedenleriEkleDTO ıstenAyrilmaNedenleriEkleDTO);
        Task<IstenAyrilmaNedenleriDTO> IstenAyrilmaNedenGuncelle(IstenAyrilmaNedenleriGuncelleDTO ıstenAyrilmaNedenleriGuncelleDTO);
        Task<bool> IstenAyrilmaNedenSil(int istenAyrilmaNedenId);
        Task<List<IstenAyrilmaNedenleriDTO>> IstenAyrilmaNedenleriGetir();
        Task<IzinGrupDTO> IzinGrupEkle(IzinGrupEkleDTO ızinGrupEkleDTO);
        Task<IzinGrupDTO> IzinGrupGuncelle(IzinGrupGuncelleDTO kademeGuncelleDTO);
        Task<bool> IzinGrupSil(int izinGrupId);
        Task<List<IzinGrupDTO>> IzinGruplariGetir();
        Task<List<OgrenimDurumDTO>> OgrenimDurumlariGetir();
        Task<List<SigortaTurDTO>> SigortaTurleriGetir();
        Task<List<SozlesmeTurDTO>> SozlesmeTurleriGetir();


    }
}

