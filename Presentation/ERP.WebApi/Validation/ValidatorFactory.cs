using ERP.WebApi.Validation.FirmaSubeValidation;
using ERP.WebApi.Validation.IstenAyrilmaNedenleriValidation;
using ERP.WebApi.Validation.IzinGrubuValidation;
using ERP.WebApi.Validation.KullaniciYetkileriValidation;
using ERP.WebApi.Validation.OrganizasyonValidation;
using ERP.WebApi.Validation.PersonelKanun;
using ERP.WebApi.Validation.YetkiGruplariDetayValidation;
using ERP.WebApi.Validation.YetkiGruplariValidation;
using ERP.WebApi.Validation.YetkilerValidation;

namespace ERP.WebApi.Validation
{
    public static class ValidatorFactory
    {
        public static IBlogValidator GetBlogValidator()
        {
            return new BlogValidator();
        }

        public static IPersonelValidator PersonelValidator()
        {
            return new PersonelValidator();
        }
        public static IFirmaSubeValidator FirmaSubeValidator()
        {
            return new FirmaSubeValidator();
        }
        public static IOrganizasyonValidator OrganizasyonValidator()
        {
            return new OrganizasyonValidator();
        }
        public static IIstenAyrilmaNedenleriValidator IstenAyrilmaNedenleriValidator()
        {
            return new IstenAyrilmaNedenleriValidator();
        }
        public static IIzinGrupValidator IzinGrupValidator()
        {
            return new IzinGrupValidator();
        }
        public static IYetkilerValidator YetkilerValidator()
        {
            return new YetkilerValidator();
        }
        public static IYetkiGruplariValidator YetkiGruplariValidator()
        {
            return new YetkiGruplariValidator();
        }
        public static IYetkiGruplariDetayValidator YetkiGruplariDetayValidator()
        {
            return new YetkiGruplariDetayValidator();
        }
        public static IKullaniciYetkileriValidator KullaniciYetkileriValidator()
        {
            return new KullaniciYetkileriValidator();
        }
        public static IPersonelKanunValidator PersonelKanunValidator()
        {
            return new PersonelKanunValidator();
        }
    }
}
