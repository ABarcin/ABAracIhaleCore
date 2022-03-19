using AB_AracIhaleCore.DAL.DAL.Abstract;
using AB_AracIhaleCore.DAL.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AB_AracIhaleCore.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IKullaniciDAL _dal;
        IConfiguration _conf;
        public AuthController(IKullaniciDAL dal, IConfiguration conf)
        {
            _dal = dal;
            _conf = conf;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO dto)
        {
            var bulunanUser = _dal.Login(dto.UserName, dto.Password);
            if (bulunanUser == null)
            {
                return null;
            }
            else
            {
                var key = Encoding.ASCII.GetBytes(_conf.GetSection("AppSettings:Token").Value);

                var description = new SecurityTokenDescriptor()
                {
                    Expires = DateTime.Now.AddDays(1),
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, bulunanUser.KullaniciId.ToString()),
                        new Claim(ClaimTypes.Name, bulunanUser.KullaniciAd)
                    }),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(description);
                var tokenDegeri = tokenHandler.WriteToken(token);
                return StatusCode(202,tokenDegeri);
            }
        }
    }
}
