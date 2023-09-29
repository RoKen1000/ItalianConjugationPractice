using LanguagePractice.DataAccess.DataContext;
using LanguagePracticeSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguagePracticeSite.Controllers
{
    public class ManagementController : Controller
    {
        private readonly WordDatabaseContext _db;
        public ManagementController(WordDatabaseContext db)
        {
            _db = db;
        }

        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[controller]/[action]")]
        public IActionResult DisplayPresentIndicatives()
        {
            IEnumerable<PresentIndicative> presIndWords = _db.PresentIndicativeWords;

            return View(presIndWords);
        }

        [Route("[controller]/[action]")]
        public IActionResult CreatePresentIndicative()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        public IActionResult CreatePresentIndicative(PresentIndicative newPresentIndicative)
        {
            return View(newPresentIndicative);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/[action]")]
        //public IActionResult Create(PresentPerfect newPresentPerfect)
        //{
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/[action]")]
        //public IActionResult Create(Imperfect newImperfect)
        //{
        //    return RedirectToAction("Index");
        //}
    }
}
