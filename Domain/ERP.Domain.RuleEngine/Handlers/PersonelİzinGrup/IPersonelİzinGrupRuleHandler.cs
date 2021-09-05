using ERP.Data.Entities;
using ERP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.PersonelİzinGrup
{
    public interface IPersonelİzinGrupRuleHandler
    {
        IRuleValidationResult ValidatePersonelİzinGrupEkle(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu);
                                      
        IRuleValidationResult ValidatePersonelİzinGrupGuncelle(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu);
                                     
        IRuleValidationResult ValidatePersonelİzinGrupSil(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu);
    }
}
