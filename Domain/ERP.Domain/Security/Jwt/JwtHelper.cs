using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Core.Extensions;
using Domain.Security.Encyption;
using ERP.Data.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Security.Jwt
{
    public class JwtHelper:ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            
        }
        public AccessToken CreateToken(kullanici kullanici, List<yetkiler> yetkiler)
        {

            

            string secretKey = Configuration["TokenOptions:SecurityKey"];
            
            var key = Encoding.ASCII.GetBytes(secretKey);
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration); 
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, kullanici, signingCredentials, yetkiler);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, kullanici kullanici, 
            SigningCredentials signingCredentials, List<yetkiler> yetkiler)
        {
            var jwt = new JwtSecurityToken(
                issuer:tokenOptions.Issuer,
                audience:tokenOptions.Audience,
                expires:_accessTokenExpiration,
                notBefore:DateTime.Now,
                claims: SetClaims(kullanici, yetkiler),
                signingCredentials:signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(kullanici kullanici, List<yetkiler> yetkiler)
        {
            var claims = new List<Claim>();
            
            claims.AddNameIdentifier((kullanici.personel?.personelKimlik?.tckNo != null) ? kullanici.personel?.personelKimlik?.tckNo.ToString() : "");
            claims.AddEmail(kullanici.email);
            claims.AddName($"{kullanici.personel.adi} {kullanici.personel.soyadi}");
            claims.AddRoles(yetkiler.Select(c=>c.adi).ToArray());
            
            return claims;
        }
    }
}
