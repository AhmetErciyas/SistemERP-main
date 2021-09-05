using ERP.Application.DTOs.OrganizasyonDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public interface IOrganizasyonValidator
    {
        string[] ValidateKademeEkle(KademeEkleDTO kademeEkleDTO);
        string[] ValidateKademeGetir(int id);
        string[] ValidateKademeAra(KademeDTO kademeAraDTO);
        string[] ValidateKademeGuncelle(KademeGuncelleDTO kademeGuncelleDTO);

        string[] ValidateDepartmanEkle(DepartmanEkleDTO departmanEkleDTO);
        string[] ValidateDepartmanGetir(int id);
        string[] ValidateDepartmanAra(DepartmanDTO departmanAraDTO);
        string[] ValidateDepartmanGuncelle(DepartmanDTO departmanGuncelleDTO);

        string[] ValidateUnvanEkle(UnvanEkleDTO unvanEkleDTO);
        string[] ValidateUnvanGetir(int id);
        string[] ValidateUnvanAra(UnvanDTO unvanAraDTO);
        string[] ValidateUnvanGuncelle(UnvanDTO unvanGuncelleDTO);
    }
}
