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
        public async Task<IActionResult> DisplayPresentIndicatives()
        {
            IEnumerable<PresentIndicative> presIndWords = await _unitOfWork.PresentIndicative.GetAll();

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
        public async Task<IActionResult> CreatePresentIndicative(PresentIndicative newPresentIndicative)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.PresentIndicative.Create(newPresentIndicative);
                await _unitOfWork.Save();
                return RedirectToAction("DisplayPresentIndicatives");
            }
            return View(newPresentIndicative);
        }

        [Route("[controller]/[action]/{id}", Name = "PresIndEdit")]
        public async Task<IActionResult> EditPresentIndicative(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            PresentIndicative currentWord = await _unitOfWork.PresentIndicative.GetSingle(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]/{id}", Name = "PresIndEdit")]
        public async Task<IActionResult> EditPresentIndicative(PresentIndicative editedPresInd)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.PresentIndicative.Update(editedPresInd);
                await _unitOfWork.Save();
                return RedirectToAction("DisplayPresentIndicatives");
            }
            return RedirectToAction("Index");
        }

        [Route("[controller]/[action]/{id}", Name = "PresIndDelete")]
        public async Task<IActionResult> DeletePresentIndicative(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            PresentIndicative currentWord = await _unitOfWork.PresentIndicative.GetSingle(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/DeletePresentIndicative/{id}", Name = "PresIndDelete")]
        public async Task<IActionResult> DeletePresentIndicativeAction(int? id)
        {
            PresentIndicative wordToDelete = await _unitOfWork.PresentIndicative.GetSingle(w => w.Id == id);

            if (wordToDelete == null)
            {
                return NotFound();
            }

            _unitOfWork.PresentIndicative.Delete(wordToDelete);
            await _unitOfWork.Save();

            return RedirectToAction("DisplayPresentIndicatives");
        }

        ////////////////////////////////

        [Route("[controller]/[action]")]
        public async Task<IActionResult> DisplayPresentPerfects()
        {
            IEnumerable<PresentPerfect> presPerfWords = await _unitOfWork.PresentPerfect.GetAll();

            return View(presPerfWords);
        }

        [Route("[controller]/[action]")]
        public IActionResult CreatePresentPerfect()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> CreatePresentPerfect(PresentPerfect newPresentPerfect)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.PresentPerfect.Create(newPresentPerfect);
                await _unitOfWork.Save();
                return RedirectToAction("DisplayPresentPerfects");
            }
            return View(newPresentPerfect);
        }

        [Route("[controller]/[action]/{id}", Name = "PresPerfEdit")]
        public async Task<IActionResult> EditPresentPerfect(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            PresentPerfect currentWord = await _unitOfWork.PresentPerfect.GetSingle(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]/{id}", Name = "PresPerfEdit")]
        public async Task<IActionResult> EditPresentPerfect(PresentPerfect editedPresPerf)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.PresentPerfect.Update(editedPresPerf);
                await _unitOfWork.Save();
                return RedirectToAction("DisplayPresentPerfects");
            }
            return RedirectToAction("Index");
        }

        [Route("[controller]/[action]/{id}", Name = "PresPerfDelete")]
        public async Task<IActionResult> DeletePresentPerfect(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            PresentPerfect currentWord = await _unitOfWork.PresentPerfect.GetSingle(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/DeletePresentPerfect/{id}", Name = "PresPerfDelete")]
        public async Task<IActionResult> DeletePresentPerfectAction(int? id)
        {
            PresentPerfect wordToDelete = await _unitOfWork.PresentPerfect.GetSingle(w => w.Id == id);

            if (wordToDelete == null)
            {
                return NotFound();
            }

            _unitOfWork.PresentPerfect.Delete(wordToDelete);
            await _unitOfWork.Save();

            return RedirectToAction("DisplayPresentPerfects");
        }

        ////////////////////

        [Route("[controller]/[action]")]
        public async Task<IActionResult> DisplayImperfects()
        {
            IEnumerable<Imperfect> imperfectWords = await _unitOfWork.Imperfect.GetAll();

            return View(imperfectWords);
        }

        [Route("[controller]/[action]")]
        public IActionResult CreateImperfect()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> CreateImperfect(Imperfect newImperfect)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Imperfect.Create(newImperfect);
                await _unitOfWork.Save();
                return RedirectToAction("DisplayImperfects");
            }
            return View(newImperfect);
        }

        [Route("[controller]/[action]/{id}", Name = "ImperfEdit")]
        public async Task<IActionResult> EditImperfect(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Imperfect currentWord = await _unitOfWork.Imperfect.GetSingle(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]/{id}", Name = "ImperfEdit")]
        public async Task<IActionResult> EditImperfect(Imperfect editedImperf)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Imperfect.Update(editedImperf);
                await _unitOfWork.Save();
                return RedirectToAction("DisplayImperfects");
            }
            return RedirectToAction("Index");
        }

        [Route("[controller]/[action]/{id}", Name = "ImperfDelete")]
        public async Task<IActionResult> DeleteImperfect(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Imperfect currentWord = await _unitOfWork.Imperfect.GetSingle(w => w.Id == id);

            return View(currentWord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/DeleteImperfect/{id}", Name = "ImperfDelete")]
        public async Task<IActionResult> DeleteImperfectAction(int? id)
        {
            Imperfect wordToDelete = await _unitOfWork.Imperfect.GetSingle(w => w.Id == id);

            if (wordToDelete == null)
            {
                return NotFound();
            }

            _unitOfWork.Imperfect.Delete(wordToDelete);
            await _unitOfWork.Save();

            return RedirectToAction("DisplayImperfects");
        }
    }
}
