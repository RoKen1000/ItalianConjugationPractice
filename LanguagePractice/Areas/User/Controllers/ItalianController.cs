using LanguagePractice.DataAccess.DataContext;
using LanguagePracticeSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguagePracticeSite.Areas.User.Controllers
{
    public class ItalianController : Controller
    {
        private readonly WordDatabaseContext _db;
        public ItalianController(WordDatabaseContext db)
        {
            _db = db;
        }

        private int ProduceRandomOffset(string verbTense)
        {
            int wordCount;

            switch (verbTense)
            {
                case "present indicative":
                    wordCount = _db.PresentIndicativeWords.Count();
                    break;
                case "present perfect":
                    wordCount = _db.PresentPerfectPhrases.Count();
                    break;
                case "imperfect":
                    wordCount = _db.ImperfectWords.Count();
                    break;
                default:
                    wordCount = 0;
                    break;
            }

            Random r = new Random();
            int offset = r.Next(0, wordCount);

            return offset;
        }

        public IActionResult PresentIndicative()
        {
            PresentIndicative retrievedWord = _db.PresentIndicativeWords.Skip(ProduceRandomOffset("present indicative")).FirstOrDefault();

            return View(retrievedWord);
        }

        public IActionResult PresentPerfect()
        {
            PresentPerfect retrievedWord = _db.PresentPerfectPhrases.Skip(ProduceRandomOffset("present perfect")).FirstOrDefault();

            return View(retrievedWord);
        }

        public IActionResult Imperfect()
        {
            Imperfect retrievedWord = _db.ImperfectWords.Skip(ProduceRandomOffset("imperfect")).FirstOrDefault();

            return View(retrievedWord);
        }
    }
}
