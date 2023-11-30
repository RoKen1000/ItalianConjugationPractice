using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguagePracticeSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagementController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManagementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            if (ModelState.IsValid)
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
            if (id == null || id == 0)
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

        //[Route("[controller]/[action]")]
        //public IActionResult DisplayPresentPerfects()
        //{
        //    IEnumerable<PresentPerfect> presPerfWords = _db.PresentPerfectPhrases;

        //    return View(presPerfWords);
        //}

        //[Route("[controller]/[action]")]
        //public IActionResult CreatePresentPerfect()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/[action]")]
        //public IActionResult CreatePresentPerfect(PresentPerfect newPresentPerfect)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.PresentPerfectPhrases.Add(newPresentPerfect);
        //        _db.SaveChanges();
        //        return RedirectToAction("DisplayPresentPerfects");
        //    }
        //    return View(newPresentPerfect);
        //}

        //[Route("[controller]/[action]/{id}", Name = "PresPerfEdit")]
        //public IActionResult EditPresentPerfect(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    PresentPerfect currentWord = _db.PresentPerfectPhrases.FirstOrDefault(w => w.Id == id);

        //    return View(currentWord);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/[action]/{id}", Name = "PresPerfEdit")]
        //public IActionResult EditPresentPerfect(PresentPerfect editedPresPerf)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.PresentPerfectPhrases.Update(editedPresPerf);
        //        _db.SaveChanges();
        //        return RedirectToAction("DisplayPresentPerfects");
        //    }
        //    return RedirectToAction("Index");
        //}

        //[Route("[controller]/[action]/{id}", Name = "PresPerfDelete")]
        //public IActionResult DeletePresentPerfect(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    PresentPerfect currentWord = _db.PresentPerfectPhrases.FirstOrDefault(w => w.Id == id);

        //    return View(currentWord);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/DeletePresentPerfect/{id}", Name = "PresPerfDelete")]
        //public IActionResult DeletePresentPerfectAction(int? id)
        //{

        //    PresentPerfect wordToDelete = _db.PresentPerfectPhrases.FirstOrDefault(w => w.Id == id);

        //    if (wordToDelete == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.PresentPerfectPhrases.Remove(wordToDelete);
        //    _db.SaveChanges();

        //    return RedirectToAction("DisplayPresentPerfects");
        //}

        ////////////////////

        //[Route("[controller]/[action]")]
        //public IActionResult DisplayImperfects()
        //{
        //    IEnumerable<Imperfect> presIndWords = _db.ImperfectWords;

        //    return View(presIndWords);
        //}

        //[Route("[controller]/[action]")]
        //public IActionResult CreateImperfect()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/[action]")]
        //public IActionResult CreateImperfect(Imperfect newImperfect)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.ImperfectWords.Add(newImperfect);
        //        _db.SaveChanges();
        //        return RedirectToAction("DisplayImperfects");
        //    }
        //    return View(newImperfect);
        //}

        //[Route("[controller]/[action]/{id}", Name = "ImperfEdit")]
        //public IActionResult EditImperfect(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    Imperfect currentWord = _db.ImperfectWords.FirstOrDefault(w => w.Id == id);

        //    return View(currentWord);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/[action]/{id}", Name = "ImperfEdit")]
        //public IActionResult EditImperfect(Imperfect editedImperf)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.ImperfectWords.Update(editedImperf);
        //        _db.SaveChanges();
        //        return RedirectToAction("DisplayImperfects");
        //    }
        //    return RedirectToAction("Index");
        //}

        //[Route("[controller]/[action]/{id}", Name = "ImperfDelete")]
        //public IActionResult DeleteImperfect(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    Imperfect currentWord = _db.ImperfectWords.FirstOrDefault(w => w.Id == id);

        //    return View(currentWord);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("[controller]/DeleteImperfect/{id}", Name = "ImperfDelete")]
        //public IActionResult DeleteImperfectAction(int? id)
        //{

        //    Imperfect wordToDelete = _db.ImperfectWords.FirstOrDefault(w => w.Id == id);

        //    if (wordToDelete == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.ImperfectWords.Remove(wordToDelete);
        //    _db.SaveChanges();

        //    return RedirectToAction("DisplayImperfects");
        //}
    }
}
