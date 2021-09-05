using ERP.Data.Interfaces;

namespace ERP.Domain.RuleEngine.Handlers
{
    public interface IPersonelRuleHandler
    {
        IRuleValidationResult ValidatePersonelEkle(IPersonelRepository personelRepository, IKisiRepository kisiRepository, ERP.Data.Entities.personel Personel);
        IRuleValidationResult ValidatePersonelGuncelle(IPersonelRepository personelRepository, IKisiRepository kisiRepository, ERP.Data.Entities.personel Personel);

    }
}
