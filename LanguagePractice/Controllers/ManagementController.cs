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
            if(ModelState.IsValid)
            {
                _db.PresentIndicativeWords.Add(newPresentIndicative);
                _db.SaveChanges();
                return RedirectToAction("DisplayPresentIndicatives");
            }
            return View(newPresentIndicative);
        }

        [Route("[controller]/[action]/{id}", Name = "PresIndEdit")]
        public IActionResult EditPresentIndicative(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            PresentIndicative currentWord = _db.PresentIndicativeWords.FirstOrDefault(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]/{id}", Name = "PresIndEdit")]
        public IActionResult EditPresentIndicative(PresentIndicative editedPresInd)
        {
            if (ModelState.IsValid)
            {
                _db.PresentIndicativeWords.Update(editedPresInd);
                _db.SaveChanges();
                return RedirectToAction("DisplayPresentIndicatives");   
            }
            return RedirectToAction("Index");
        }

        [Route("[controller]/[action]/{id}", Name = "PresIndDelete")]
        public IActionResult DeletePresentIndicative(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            PresentIndicative currentWord = _db.PresentIndicativeWords.FirstOrDefault(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/DeletePresentIndicative/{id}", Name = "PresIndDelete")]
        public IActionResult DeletePresentIndicativeAction(int? id)
        {
            
            PresentIndicative wordToDelete = _db.PresentIndicativeWords.FirstOrDefault(w => w.Id == id);

            if (wordToDelete == null)
            {
                return NotFound();
            }

            _db.PresentIndicativeWords.Remove(wordToDelete);
            _db.SaveChanges();

            return RedirectToAction("DisplayPresentIndicatives");
        }

        ////////////////////////////////

        [Route("[controller]/[action]")]
        public IActionResult DisplayPresentPerfects()
        {
            IEnumerable<PresentPerfect> presIndWords = _db.PresentPerfectPhrases;

            return View(presIndWords);
        }
    }
}
