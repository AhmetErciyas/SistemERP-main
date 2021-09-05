using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.YetkiGrup
{
    public class YetkiGrupRuleHandler: IYetkiGrupRuleHandler
    {
        private readonly ISessionFactory sessionFactory;

        public YetkiGrupRuleHandler(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public IRuleValidationResult ValidateYetkiGrupEkle(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("YetkiGrupEkle")));
            session.Insert(yetkiGuruplariRepository);
            session.Insert(yetkiGruplari);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateYetkiGrupGuncelle(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("YetkiGrupGuncelle")));
            session.Insert(yetkiGuruplariRepository);
            session.Insert(yetkiGruplari);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateYetkiGrupSil(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("YetkiGrupSil")));
            session.Insert(yetkiGuruplariRepository);
            session.Insert(yetkiGruplari);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }
    }
}
