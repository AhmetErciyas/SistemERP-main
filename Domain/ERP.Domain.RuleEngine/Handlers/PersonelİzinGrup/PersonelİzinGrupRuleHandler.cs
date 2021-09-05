using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.PersonelİzinGrup
{
    public class PersonelİzinGrupRuleHandler: IPersonelİzinGrupRuleHandler
    {
        private readonly ISessionFactory sessionFactory;

        public PersonelİzinGrupRuleHandler(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public IRuleValidationResult ValidatePersonelİzinGrupEkle(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("IzinGrupEkle")));
            session.Insert(personelIzinGrupRepository);
            session.Insert(izinGrubu);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidatePersonelİzinGrupGuncelle(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("IzinGrupGuncelle")));
            session.Insert(personelIzinGrupRepository);
            session.Insert(izinGrubu);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidatePersonelİzinGrupSil(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("IzinGrupSil")));
            session.Insert(personelIzinGrupRepository);
            session.Insert(izinGrubu);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }
    }
}
