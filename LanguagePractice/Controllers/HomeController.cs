using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace LanguagePractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly WordDatabaseContext _db;
       
        public HomeController(ILogger<HomeController> logger, WordDatabaseContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {

            int wordCount = _db.PresentIndicativeWords.Count();
            Random r = new Random();
            int offset = r.Next(0, wordCount);
            PresentIndicative retrievedWord = _db.PresentIndicativeWords.Skip(offset).FirstOrDefault();

            return View(retrievedWord);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}