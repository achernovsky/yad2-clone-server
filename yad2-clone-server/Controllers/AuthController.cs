using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using yad2_clone_server.Models;
using yad2_clone_server.Repositories;

namespace yad2_clone_server.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthRepo _repository;

        public AuthController(IAuthRepo repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            await _repository.Register(model);
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var token = await _repository.Login(model);
            if (token != null)
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    username = token.Claims.ToArray()[0].Value,
                    userid = token.Claims.ToArray()[1].Value
                });
            else
                return Unauthorized();
        }
    }
}
