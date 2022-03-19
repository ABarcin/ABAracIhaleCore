using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.UI.Controllers
{
    public class IhaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IhaleEkle()
        {
            return View();
        }
    }
}
