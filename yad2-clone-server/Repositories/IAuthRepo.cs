using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using yad2_clone_server.Models;

namespace yad2_clone_server.Repositories
{
    public interface IAuthRepo
    {
        Task Register(RegisterModel model);
        Task<JwtSecurityToken> Login(LoginModel model);
    }
}
