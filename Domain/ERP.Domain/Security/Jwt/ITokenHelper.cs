using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(kullanici kullanici, List<yetkiler> yetkiler);
    }
}
