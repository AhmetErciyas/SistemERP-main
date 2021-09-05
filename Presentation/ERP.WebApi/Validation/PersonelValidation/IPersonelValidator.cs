using ERP.Application.DTOs.PersonelDTOs;

namespace ERP.WebApi.Validation
{
    public interface IPersonelValidator
    {
        string[] ValidatePersonelEkle(PersonelEkleDTO personelEkleDTO);
        string[] ValidatePersonelGetir(int id);
        string[] ValidatePersonelAra(PersonelAraDTO personelAraDTO);
        string[] ValidatePersonelGuncelle(PersonelGuncelleDTO personelGuncelleDTO);
    }
}
