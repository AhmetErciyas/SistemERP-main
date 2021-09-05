using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.IstenAyrılmaNeden
{
    public class IstenAyrılmaNedenRuleHandler:IIstenAyrılmaNedenRuleHandler
    {
        private readonly ISessionFactory sessionFactory;

        public IstenAyrılmaNedenRuleHandler(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public IRuleValidationResult ValidateIstenAyrılmaNedenEkle(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("IstenAyrılmaNedenEkle")));
            session.Insert(ıstenAyrilmaNedenleriRepository);
            session.Insert(istenAyrilmaNedenleri);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateIstenAyrılmaNedenGuncelle(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("IstenAyrılmaNedenGuncelle")));
            session.Insert(ıstenAyrilmaNedenleriRepository);
            session.Insert(istenAyrilmaNedenleri);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateIstenAyrılmaNedenSil(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("IstenAyrılmaNedenSil")));
            session.Insert(ıstenAyrilmaNedenleriRepository);
            session.Insert(istenAyrilmaNedenleri);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }
    }
}
