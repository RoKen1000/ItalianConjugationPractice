using LanguagePracticeSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace LanguagePracticeSite.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Demo()
        {
            return View();
        }
    }
}