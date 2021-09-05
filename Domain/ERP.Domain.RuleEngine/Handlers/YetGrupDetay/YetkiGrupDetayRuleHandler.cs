using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.YetGrupDetay
{
    public class YetkiGrupDetayRuleHandler: IYetkiGrupDetayRuleHandler
    {
        private readonly ISessionFactory sessionFactory;

        public YetkiGrupDetayRuleHandler(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public IRuleValidationResult ValidateYetkiGrupDetayEkle(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, IYetkilerRepository yetkilerRepository, IGrupRepository grupRepository, yetkiGruplariDetay yetkiGruplariDetay)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("YetkiGrupDetayEkle")));
            session.Insert(yetkiGuruplariDetayRepository);
            session.Insert(yetkilerRepository);
            session.Insert(grupRepository);
            session.Insert(yetkiGruplariDetay);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateYetkiGrupDetayGuncelle(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, IYetkilerRepository yetkilerRepository, IGrupRepository grupRepository, yetkiGruplariDetay yetkiGruplariDetay)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("YetkiGrupDetayGuncelle")));
            session.Insert(yetkiGuruplariDetayRepository);
            session.Insert(yetkilerRepository);
            session.Insert(grupRepository);
            session.Insert(yetkiGruplariDetay);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateYetkiGrupDetaySil(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, yetkiGruplariDetay yetkiGruplariDetay)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("YetkiGrupDetaySil")));
            session.Insert(yetkiGuruplariDetayRepository);
            session.Insert(yetkiGruplariDetay);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }
    }
}
