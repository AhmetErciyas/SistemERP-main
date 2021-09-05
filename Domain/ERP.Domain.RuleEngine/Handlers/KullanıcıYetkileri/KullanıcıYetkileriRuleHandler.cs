using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.KullanıcıYetkileri
{
    public class KullanıcıYetkileriRuleHandler:IKullanıcıYetkileriRuleHandler
    {
        private readonly ISessionFactory sessionFactory;

        public KullanıcıYetkileriRuleHandler(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public IRuleValidationResult ValidateKullanıcıYetkileriEkle(IKullaniciYetkileriRepository kullaniciYetkilerRepository, IKullaniciRepository kullaniciRepository, IYetkilerRepository yetkilerRepository, kullaniciYetkileri kullaniciYetkileri)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("KullanicıYetkiEkle")));
            session.Insert(kullaniciYetkilerRepository);
            session.Insert(kullaniciRepository); 
            session.Insert(yetkilerRepository);
            session.Insert(kullaniciYetkileri);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateKullanıcıYetkileriGuncelle(IKullaniciYetkileriRepository kullaniciYetkilerRepository, IKullaniciRepository kullaniciRepository, IYetkilerRepository yetkilerRepository, kullaniciYetkileri kullaniciYetkileri)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("KullanicıYetkiGuncelle")));
            session.Insert(kullaniciYetkilerRepository);
            session.Insert(kullaniciRepository);
            session.Insert(yetkilerRepository);
            session.Insert(kullaniciYetkileri);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateKullanıcıYetkileriSil(IKullaniciYetkileriRepository kullaniciYetkilerRepository, kullaniciYetkileri kullaniciYetkileri)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("KullanicıYetkiSil")));
            session.Insert(kullaniciYetkilerRepository);
            session.Insert(kullaniciYetkileri);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }
    }
}
