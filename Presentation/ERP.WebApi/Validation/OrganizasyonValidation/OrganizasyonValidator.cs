using ERP.Application.DTOs.OrganizasyonDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public class OrganizasyonValidator : IOrganizasyonValidator
    {
        public string[] ValidateDepartmanAra(DepartmanDTO departmanAraDTO)
        {
            return new DepartmanAraValidator().ValidateModel(departmanAraDTO);
        }

        public string[] ValidateDepartmanEkle(DepartmanEkleDTO departmanEkleDTO)
        {
            return new DepartmanEkleValidator().ValidateModel(departmanEkleDTO);
        }

        public string[] ValidateDepartmanGetir(int id)
        {
            return new DepartmanGetirValidator().ValidateModel(id);
        }

        public string[] ValidateDepartmanGuncelle(DepartmanDTO departmanGuncelleDTO)
        {
            return new DepartmanGuncelleValidator().ValidateModel(departmanGuncelleDTO);
        }

        public string[] ValidateKademeAra(KademeDTO kademeAraDTO)
        {
            return new KademeAraValidator().ValidateModel(kademeAraDTO);
        }

        public string[] ValidateKademeEkle(KademeEkleDTO kademeEkleDTO)
        {
            return new KademeEkleValidator().ValidateModel(kademeEkleDTO);
        }

        public string[] ValidateKademeGetir(int id)
        {
            return new KademeGetirValidator().ValidateModel(id);
        }

        public string[] ValidateKademeGuncelle(KademeGuncelleDTO kademeGuncelleDTO)
        {
            return new KademeGuncelleValidator().ValidateModel(kademeGuncelleDTO);
        }

       

        public string[] ValidateUnvanAra(UnvanDTO unvanAraDTO)
        {
            return new UnvanAraValidator().ValidateModel(unvanAraDTO);
        }

        public string[] ValidateUnvanEkle(UnvanEkleDTO unvanEkleDTO)
        {
            return new UnvanEkleValidator().ValidateModel(unvanEkleDTO);
        }

        public string[] ValidateUnvanGetir(int id)
        {
            return new UnvanGetirValidator().ValidateModel(id);
        }

        public string[] ValidateUnvanGuncelle(UnvanDTO unvanGuncelleDTO)
        {
            return new UnvanGuncelleValidator().ValidateModel(unvanGuncelleDTO);
        }
    }
}
