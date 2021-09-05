using ERP.Data.Entities;
using ERP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.YetGrupDetay
{
    public interface IYetkiGrupDetayRuleHandler
    {
        IRuleValidationResult ValidateYetkiGrupDetayEkle(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, IYetkilerRepository yetkilerRepository, IGrupRepository grupRepository, yetkiGruplariDetay yetkiGruplariDetay);

        IRuleValidationResult ValidateYetkiGrupDetayGuncelle(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, IYetkilerRepository yetkilerRepository, IGrupRepository grupRepository, yetkiGruplariDetay yetkiGruplariDetay);

        IRuleValidationResult ValidateYetkiGrupDetaySil(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, yetkiGruplariDetay yetkiGruplariDetay);
    }
}
