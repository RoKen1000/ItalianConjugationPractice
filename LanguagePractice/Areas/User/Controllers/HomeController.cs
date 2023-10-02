using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace LanguagePracticeSite.Areas.User.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}