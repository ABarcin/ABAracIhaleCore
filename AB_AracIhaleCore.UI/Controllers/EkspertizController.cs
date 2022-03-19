using AB_AracIhaleCore.UI.Common;
using AB_AracIhaleCore.UI.Provider;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AB_AracIhaleCore.UI.Controllers
{
    public class EkspertizController : Controller
    {
        TokenProvider _tokenPro;
        public EkspertizController(TokenProvider tokenPro)
        {
            _tokenPro = tokenPro;
        }
        [HttpGet]
        public async Task<IActionResult> GetEkspertizByAracID()
        {
            string gelenTokenDegeri = "";
            if (HttpContext.Session.MySessionGet<string>("token") == null)
            {
                gelenTokenDegeri =await _tokenPro.TokenAl("faylan", "123");
                HttpContext.Session.MySessionSet("token", gelenTokenDegeri);
            }
            else
            {
                gelenTokenDegeri = HttpContext.Session.MySessionGet<string>("token").ToString();
            }
            return View();
        }
    }
}
