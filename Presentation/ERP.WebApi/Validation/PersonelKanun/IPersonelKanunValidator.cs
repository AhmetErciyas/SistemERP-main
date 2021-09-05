using ERP.Application.DTOs.PersonelKanun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.PersonelKanun
{
    public interface IPersonelKanunValidator
    {
        string[] ValidatePersonelKanunEkle(PersonelKanunEkleDTO personelKanunEkleDTO);
        string[] ValidatePersonelKanunSil(int id);
        string[] ValidatePersonelKanunGuncelle(PersonelKanunGuncelleDTO personelKanunGuncelleDTO);
    }
}
