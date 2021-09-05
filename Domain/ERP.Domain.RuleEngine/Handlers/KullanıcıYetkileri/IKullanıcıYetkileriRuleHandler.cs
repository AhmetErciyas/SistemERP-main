using ERP.Data.Entities;
using ERP.Data.Interfaces;

namespace ERP.Domain.RuleEngine.Handlers.KullanıcıYetkileri
{
    public interface IKullanıcıYetkileriRuleHandler
    {
        IRuleValidationResult ValidateKullanıcıYetkileriEkle(IKullaniciYetkileriRepository kullaniciYetkilerRepository, IKullaniciRepository kullaniciRepository, IYetkilerRepository yetkilerRepository, kullaniciYetkileri kullaniciYetkileri);

        IRuleValidationResult ValidateKullanıcıYetkileriGuncelle(IKullaniciYetkileriRepository kullaniciYetkilerRepository, IKullaniciRepository kullaniciRepository, IYetkilerRepository yetkilerRepository, kullaniciYetkileri kullaniciYetkileri);

        IRuleValidationResult ValidateKullanıcıYetkileriSil(IKullaniciYetkileriRepository kullaniciYetkilerRepository, kullaniciYetkileri kullaniciYetkileri);
    }
}
