using ERP.Application.DTOs.PersonelKanun;
using ERP.WebApi.Validation.PersonelKanun.PersonelKanun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.PersonelKanun
{
    public class PersonelKanunValidator : IPersonelKanunValidator
    {
        public string[] ValidatePersonelKanunEkle(PersonelKanunEkleDTO personelKanunEkleDTO)
        {
            return new PersonelKanunEkleValidator().ValidateModel(personelKanunEkleDTO);
        }

        public string[] ValidatePersonelKanunGuncelle(PersonelKanunGuncelleDTO personelKanunGuncelleDTO)
        {
            return new PersonelKanunGuncelleValidator().ValidateModel(personelKanunGuncelleDTO);
        }

        public string[] ValidatePersonelKanunSil(int id)
        {
            return new PersonelKanunSilValidator().ValidateModel(id);
        }
    }
}
