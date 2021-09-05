using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.RuleEngine.Handlers;
using ERP.Domain.RuleEngine.Handlers.Blog;
using ERP.Domain.RuleEngine.Handlers.IstenAyrılmaNeden;
using ERP.Domain.RuleEngine.Handlers.KullanıcıYetkileri;
using ERP.Domain.RuleEngine.Handlers.Personel;
using ERP.Domain.RuleEngine.Handlers.PersonelİzinGrup;
using ERP.Domain.RuleEngine.Handlers.YetGrupDetay;
using ERP.Domain.RuleEngine.Handlers.YetkiGrup;
using NRules;
using NRules.Fluent;
using NRules.Fluent.Dsl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Domain.RuleEngine
{
    public interface IRuleManager : IBlogRuleHandler, IPersonelRuleHandler
    {
    }

    public sealed class RuleManager : IRuleManager
    {
        private static readonly Lazy<RuleManager> lazy = new Lazy<RuleManager>(() => new RuleManager());

        // NRule instances
        private readonly RuleRepository repository;

        private readonly ISessionFactory sessionFactory;
        private readonly IBlogRuleHandler blogRuleHandler;
        private readonly IPersonelRuleHandler personelRuleHandler;
        private readonly IYetkiGrupDetayRuleHandler yetkiGrupDetayRuleHandler;
        private readonly IIstenAyrılmaNedenRuleHandler ıstenAyrılmaNedenRuleHandler;
        private readonly IYetkiGrupRuleHandler yetkiGrupRuleHandler;
        private readonly IKullanıcıYetkileriRuleHandler kullanıcıYetkileriRuleHandler;
        private readonly IPersonelİzinGrupRuleHandler personelİzinGrupRuleHandler;


        public static RuleManager Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        // Not: eğer burada kırılma olursa rule'lardan birinde hata vardır, orada kırılıyordur.
        private List<Type> FetchAllRulesByReflection()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.FullName.Contains("ERP"))
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(Rule).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();
        }

        private RuleManager()
        {
            // initialize NRule
            repository = new RuleRepository();
            repository.Load(x => x.From(FetchAllRulesByReflection()));
            sessionFactory = repository.Compile();

            // initialize handlers
            blogRuleHandler = new BlogRuleHandler(sessionFactory);
           personelRuleHandler= new PersonelRuleHandler(sessionFactory);
            yetkiGrupDetayRuleHandler = new YetkiGrupDetayRuleHandler(sessionFactory);
            kullanıcıYetkileriRuleHandler = new KullanıcıYetkileriRuleHandler(sessionFactory);
            yetkiGrupRuleHandler = new YetkiGrupRuleHandler(sessionFactory);
            personelİzinGrupRuleHandler = new PersonelİzinGrupRuleHandler(sessionFactory);
            ıstenAyrılmaNedenRuleHandler = new IstenAyrılmaNedenRuleHandler(sessionFactory);
        }

        #region Blog rule handler

        public IRuleValidationResult ValidatePostEkle(IPostRepository repository1, IAuthorRepository repository2, Post post)
        {
            return blogRuleHandler.ValidatePostEkle(repository1, repository2, post);
        }

        public IRuleValidationResult ValidatePostGuncelle(IPostRepository repository, Post post)
        {
            return blogRuleHandler.ValidatePostGuncelle(repository, post);
        }

        public IRuleValidationResult ValidatePostSil(IPostRepository repository, Post post)
        {
            return blogRuleHandler.ValidatePostSil(repository, post);
        }

        public IRuleValidationResult ValidateAuthorEkle(IAuthorRepository repository, Author Author)
        {
            return blogRuleHandler.ValidateAuthorEkle(repository, Author);
        }

        public IRuleValidationResult ValidateAuthorGuncelle(IAuthorRepository repository, Author Author)
        {
            return blogRuleHandler.ValidateAuthorGuncelle(repository, Author);
        }

        public IRuleValidationResult ValidateAuthorSil(IAuthorRepository repository, Author Author)
        {
            return blogRuleHandler.ValidateAuthorSil(repository, Author);
        }

        public IRuleValidationResult ValidateCommentEkle(ICommentRepository repository, Comment Comment)
        {
            return blogRuleHandler.ValidateCommentEkle(repository, Comment);
        }

        public IRuleValidationResult ValidateCommentGuncelle(ICommentRepository repository, Comment Comment)
        {
            return blogRuleHandler.ValidateCommentGuncelle(repository, Comment);
        }

        public IRuleValidationResult ValidateCommentSil(ICommentRepository repository, Comment Comment)
        {
            return blogRuleHandler.ValidateCommentSil(repository, Comment);
        }

        #endregion

        #region Personel
        public IRuleValidationResult ValidatePersonelEkle(IPersonelRepository personelRepository, IKisiRepository kisiRepository, personel personel)
        {
            return personelRuleHandler.ValidatePersonelEkle(personelRepository, kisiRepository, personel);
        }
        public IRuleValidationResult ValidatePersonelGuncelle(IPersonelRepository personelRepository, IKisiRepository kisiRepository, personel personel)
        {
            return personelRuleHandler.ValidatePersonelGuncelle(personelRepository, kisiRepository, personel);
        }
        #endregion
        #region YetkiGruplariDetay
        public IRuleValidationResult ValidateYetkiGrupDetayEkle(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, IYetkilerRepository yetkilerRepository, IGrupRepository grupRepository, yetkiGruplariDetay yetkiGruplariDetay)
        {
            return yetkiGrupDetayRuleHandler.ValidateYetkiGrupDetayEkle(yetkiGuruplariDetayRepository,yetkilerRepository,grupRepository, yetkiGruplariDetay);
        }
        public IRuleValidationResult YetkiGruplariDetayGuncelle(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, IYetkilerRepository yetkilerRepository, IGrupRepository grupRepository, yetkiGruplariDetay yetkiGruplariDetay)
        {
            return yetkiGrupDetayRuleHandler.ValidateYetkiGrupDetayGuncelle(yetkiGuruplariDetayRepository,yetkilerRepository,grupRepository, yetkiGruplariDetay);
        }
        public IRuleValidationResult YetkiGruplariDetaySil(IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository, yetkiGruplariDetay yetkiGruplariDetay)
        {
            return yetkiGrupDetayRuleHandler.ValidateYetkiGrupDetaySil(yetkiGuruplariDetayRepository, yetkiGruplariDetay);
        }
        #endregion
        #region YetkiGruplar
        public IRuleValidationResult ValidateYetkiGrupEkle(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari)
        {
            return yetkiGrupRuleHandler.ValidateYetkiGrupEkle(yetkiGuruplariRepository, yetkiGruplari);
        }
        public IRuleValidationResult ValidateYetkiGrupGuncelle(IYetkiGruplariRepository yetkiGuruplariRepository ,yetkiGruplari yetkiGruplari)
        {
            return yetkiGrupRuleHandler.ValidateYetkiGrupGuncelle(yetkiGuruplariRepository, yetkiGruplari);
        }
        public IRuleValidationResult ValidateYetkiGrupSil(IYetkiGruplariRepository yetkiGuruplariRepository, yetkiGruplari yetkiGruplari)
        {
            return yetkiGrupRuleHandler.ValidateYetkiGrupSil(yetkiGuruplariRepository, yetkiGruplari);
        }
        #endregion
        #region KullanıvıYEtkileri
        public IRuleValidationResult ValidateKullanıcıYetkileriEkle(IKullaniciYetkileriRepository kullaniciYetkilerRepository, IYetkilerRepository yetkilerRepository, IKullaniciRepository kullaniciRepository, kullaniciYetkileri kullaniciYetkileri)
        {
            return kullanıcıYetkileriRuleHandler.ValidateKullanıcıYetkileriEkle(kullaniciYetkilerRepository, kullaniciRepository, yetkilerRepository, kullaniciYetkileri);
        }
        public IRuleValidationResult ValidateKullanıcıYetkileriGuncelle(IKullaniciYetkileriRepository kullaniciYetkilerRepository, IYetkilerRepository yetkilerRepository, IKullaniciRepository kullaniciRepository, kullaniciYetkileri kullaniciYetkileri)
        {
            return kullanıcıYetkileriRuleHandler.ValidateKullanıcıYetkileriGuncelle(kullaniciYetkilerRepository, kullaniciRepository, yetkilerRepository, kullaniciYetkileri);
        }
        public IRuleValidationResult ValidateKullanıcıYetkileriSil(IKullaniciYetkileriRepository kullaniciYetkilerRepository, kullaniciYetkileri kullaniciYetkileri)
        {
            return kullanıcıYetkileriRuleHandler.ValidateKullanıcıYetkileriSil(kullaniciYetkilerRepository, kullaniciYetkileri);
        }
        #endregion
        #region IStenAyrıilma
        public IRuleValidationResult ValidateIstenAyrılmaNedenEkle(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri)
        {
            return ıstenAyrılmaNedenRuleHandler.ValidateIstenAyrılmaNedenEkle(ıstenAyrilmaNedenleriRepository,  istenAyrilmaNedenleri);
        }
        public IRuleValidationResult ValidateIstenAyrılmaNedenGuncelle(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri)
        {
            return ıstenAyrılmaNedenRuleHandler.ValidateIstenAyrılmaNedenGuncelle(ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri);
        }
        public IRuleValidationResult ValidateIstenAyrılmaNedenSil(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri)
        {
            return ıstenAyrılmaNedenRuleHandler.ValidateIstenAyrılmaNedenSil(ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri);
        }
        #endregion
        #region Personelızngrup
        public IRuleValidationResult ValidatePersonelİzinGrupEkle(IIzinGrubuRepository personelIzinGrupRepository,  izinGrubu izinGrubu)
        {
            return personelİzinGrupRuleHandler.ValidatePersonelİzinGrupEkle(personelIzinGrupRepository, izinGrubu);
        }
        public IRuleValidationResult ValidatePersonelİzinGrupGuncelle(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu)
        {
            return personelİzinGrupRuleHandler.ValidatePersonelİzinGrupGuncelle(personelIzinGrupRepository, izinGrubu);
        }
        public IRuleValidationResult ValidatePersonelİzinGrupSil(IIzinGrubuRepository personelIzinGrupRepository, izinGrubu izinGrubu)
        {
            return personelİzinGrupRuleHandler.ValidatePersonelİzinGrupSil(personelIzinGrupRepository, izinGrubu);
        }
        #endregion
    }
}
