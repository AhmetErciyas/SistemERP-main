using ERP.Application.DTOs.PersonelDTOs;

namespace ERP.WebApi.Validation
{
    public class PersonelValidator : IPersonelValidator
    {
        public string[] ValidatePersonelAra(PersonelAraDTO personelAraDTO)
        {
            return new PersonelAraValidator().ValidateModel(personelAraDTO);
        }

        public string[] ValidatePersonelEkle(PersonelEkleDTO personelEkleDTO)
        {
            return new PersonelEkleValidator().ValidateModel(personelEkleDTO);
        }

        public string[] ValidatePersonelGetir(int id)
        {
            return new PersonelGetirValidator().ValidateModel(id);
        }

        public string[] ValidatePersonelGuncelle(PersonelGuncelleDTO personelGuncelleDTO)
        {
            return new PersonelGuncelleValidator().ValidateModel(personelGuncelleDTO);
        }
    }
}
