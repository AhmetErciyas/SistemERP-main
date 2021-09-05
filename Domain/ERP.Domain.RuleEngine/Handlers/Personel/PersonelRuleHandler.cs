using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Domain.RuleEngine.Handlers.Personel
{
    public class PersonelRuleHandler : IPersonelRuleHandler
    {
        private readonly ISessionFactory sessionFactory;

        public PersonelRuleHandler(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        #region Personel

        public IRuleValidationResult ValidatePersonelEkle(IPersonelRepository personelRepository, IKisiRepository kisiRepository, ERP.Data.Entities.personel Personel)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("PersonelEkle")));
            session.Insert(personelRepository);
            session.Insert(kisiRepository);
            session.Insert(Personel);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidatePersonelGuncelle(IPersonelRepository personelRepository, IKisiRepository kisiRepository, personel Personel)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("PersonelGuncelle")));
            session.Insert(personelRepository);
            session.Insert(kisiRepository);
            session.Insert(Personel);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        #endregion
    }
}
