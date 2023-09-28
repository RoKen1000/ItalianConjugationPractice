using LanguagePractice.DataAccess.DataContext;
using LanguagePracticeSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguagePracticeSite.Controllers
{
    public class ItalianController : Controller
    {
        private readonly WordDatabaseContext _db;
        public ItalianController(WordDatabaseContext db)
        {
            _db = db;
        }
        public IActionResult PresentIndicative()
        {
            int wordCount = _db.PresentIndicativeWords.Count();
            Random r = new Random();
            int offset = r.Next(0, wordCount);
            PresentIndicative retrievedWord = _db.PresentIndicativeWords.Skip(offset).FirstOrDefault();

            return View(retrievedWord);
        }

        public IActionResult PresentPerfect()
        {
            int wordCount = _db.PresentPerfectPhrases.Count();
            Random r = new Random();
            int offset = r.Next(0, wordCount);
            PresentPerfect retrievedWord = _db.PresentPerfectPhrases.Skip(offset).FirstOrDefault();

            return View(retrievedWord);
        }

        public IActionResult Imperfect()
        {
            int wordCount = _db.PresentIndicativeWords.Count();
            Random r = new Random();
            int offset = r.Next(0, wordCount);
            Imperfect retrievedWord = _db.ImperfectWords.Skip(offset).FirstOrDefault();

            return View(retrievedWord);
        }
    }
}
