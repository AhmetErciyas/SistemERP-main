using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace ERP.WebApi.Authorization
{
    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;

        public ClaimRequirementFilter(
            Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
            if (!hasClaim)
                context.Result = new ForbidResult();
        }
    }

    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(string claimType, string claimValue) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }

    public static class Permissions
    {
        public const string GetKullaniciList = "GetKullaniciList";
        

    }

    public class PermissionRequirementAttribute : ClaimRequirementAttribute
    {
        public PermissionRequirementAttribute(
            string permission) :
            base(
                "role_permission",
                permission)
        { }
    }
}
