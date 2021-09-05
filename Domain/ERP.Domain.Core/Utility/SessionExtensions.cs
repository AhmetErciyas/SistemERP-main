using ERP.Data.DAO.Kullanici;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;

namespace ERP.Domain.Core
{
    public static class SessionExtensions
    {
        private const string KULLANICI_ID = "KullaniciId";

        public static bool IsAuthenticated(this HttpContext httpContext)
        {
            return (httpContext != null) ? httpContext.User.Identity.IsAuthenticated : false;
        }

        public static KullaniciDAO GetKullanici(this HttpContext httpContext)
        {
            if (httpContext.User.Identities.Any(x => x.IsAuthenticated) == false)
                return null;

            var user = httpContext?.User;

            #region Ozelclaim
            Claim claim = null;
            #endregion

            return new KullaniciDAO()
            {
                Id = Convert.ToInt32(user.FindFirst(KULLANICI_ID)?.Value),
                TCKimlikNo = user.FindFirst(ClaimTypes.NameIdentifier)?.Value,
                Ad = user.FindFirst(ClaimTypes.Name)?.Value,
                Soyad = user.FindFirst(ClaimTypes.Surname)?.Value,
            };
        }
    }
}
