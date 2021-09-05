using ERP.Data.Entities;
using ERP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.YetkiGrup
{
    public interface IYetkiGrupRuleHandler
    {
        IRuleValidationResult ValidateYetkiGrupEkle(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari);
                                     
        IRuleValidationResult ValidateYetkiGrupGuncelle(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari);
                                     
        IRuleValidationResult ValidateYetkiGrupSil(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari);
    }
}
