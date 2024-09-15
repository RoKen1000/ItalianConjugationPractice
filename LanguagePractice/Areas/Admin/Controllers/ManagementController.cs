using AutoMapper;
using LanguagePractice.Models.ViewModels;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models;
using LanguagePracticeSite.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LanguagePracticeSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagementController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ManagementController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }

        //PresentIndicative methods
        #region

        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> DisplayPresentIndicatives()
        {
            var presIndWords = await _unitOfWork.PresentIndicative.GetAll();

            var viewModel = new ManagementIndexViewModel<PresentIndicativeViewModel>();

            if (presIndWords.IsSuccess)
            {
                viewModel.Entities = _mapper.Map<List<PresentIndicativeViewModel>>(presIndWords.DataList);
                viewModel.IsSuccess = true;
            }
            else
            {
                viewModel.IsSuccess = false;
            }

            return View(viewModel);
        }

        [HttpGet]
        [Route("[controller]/[action]")]
        public IActionResult CreatePresentIndicative()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> CreatePresentIndicative(PresentIndicativeViewModel newPresentIndicative)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<PresentIndicative>(newPresentIndicative);

                _unitOfWork.PresentIndicative.Create(entity);

                await _unitOfWork.Save();

                return RedirectToAction("DisplayPresentIndicatives");
            }
            return View(newPresentIndicative);
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}", Name = "PresIndEdit")]
        public async Task<IActionResult> EditPresentIndicative(int? id)
        {
            var currentWord = await _unitOfWork.PresentIndicative.GetSingle(w => w.Id == id);

            if(currentWord == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<PresentIndicativeViewModel>(currentWord);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]/{id}", Name = "PresIndEdit")]
        public async Task<IActionResult> EditPresentIndicative(PresentIndicativeViewModel editedPresInd)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<PresentIndicative>(editedPresInd);

                _unitOfWork.PresentIndicative.Update(entity);

                await _unitOfWork.Save();

                return RedirectToAction("DisplayPresentIndicatives");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}", Name = "PresIndDelete")]
        public async Task<IActionResult> DeletePresentIndicative(int? id)
        {
            var currentWord = await _unitOfWork.PresentIndicative.GetSingle(w => w.Id == id);

            if(!currentWord.IsSuccess)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<PresentIndicativeViewModel>(currentWord.Data);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/DeletePresentIndicative/{id}", Name = "PresIndDelete")]
        public async Task<IActionResult> DeletePresentIndicativeAction(int? id)
        {
            var wordToDelete = await _unitOfWork.PresentIndicative.GetSingle(w => w.Id == id);

            if (!wordToDelete.IsSuccess)
            {
                return NotFound();
            }

            _unitOfWork.PresentIndicative.Delete(wordToDelete.Data);
            await _unitOfWork.Save();

            return RedirectToAction("DisplayPresentIndicatives");
        }

        #endregion ewea eaweawe

        //PresentPerfect methods
        #region

        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> DisplayPresentPerfects()
        {
            var presPerfWords = await _unitOfWork.PresentPerfect.GetAll();

            var viewModel = new ManagementIndexViewModel<PresentPerfectViewModel>();

            if (presPerfWords.IsSuccess)
            {
                viewModel.Entities = _mapper.Map<List<PresentPerfectViewModel>>(presPerfWords.DataList);
                viewModel.IsSuccess = true;
            }
            else
            {
                viewModel.IsSuccess = false;
            }

            return View(viewModel);
        }

        [HttpGet]
        [Route("[controller]/[action]")]
        public IActionResult CreatePresentPerfect()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> CreatePresentPerfect(PresentPerfectViewModel newPresentPerfect)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<PresentPerfect>(newPresentPerfect);

                _unitOfWork.PresentPerfect.Create(entity);

                await _unitOfWork.Save();

                return RedirectToAction("DisplayPresentPerfects");
            }
            return View(newPresentPerfect);
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}", Name = "PresPerfEdit")]
        public async Task<IActionResult> EditPresentPerfect(int? id)
        {
            var currentWord = await _unitOfWork.PresentPerfect.GetSingle(w => w.Id == id);

            if(currentWord == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<PresentPerfectViewModel>(currentWord);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]/{id}", Name = "PresPerfEdit")]
        public async Task<IActionResult> EditPresentPerfect(PresentPerfectViewModel editedPresPerf)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<PresentPerfect>(editedPresPerf);

                _unitOfWork.PresentPerfect.Update(entity);

                await _unitOfWork.Save();

                return RedirectToAction("DisplayPresentPerfects");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}", Name = "PresPerfDelete")]
        public async Task<IActionResult> DeletePresentPerfect(int? id)
        {
            var currentWord = await _unitOfWork.PresentPerfect.GetSingle(w => w.Id == id);

            if(currentWord == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<PresentPerfectViewModel>(currentWord);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/DeletePresentPerfect/{id}", Name = "PresPerfDelete")]
        public async Task<IActionResult> DeletePresentPerfectAction(int? id)
        {
            var wordToDelete = await _unitOfWork.PresentPerfect.GetSingle(w => w.Id == id);

            if (!wordToDelete.IsSuccess)
            {
                return NotFound();
            }

            _unitOfWork.PresentPerfect.Delete(wordToDelete.Data);
            await _unitOfWork.Save();

            return RedirectToAction("DisplayPresentPerfects");
        }

        #endregion

        //Imperfect methods
        #region

        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> DisplayImperfects()
        {
            var imperfectWords = await _unitOfWork.Imperfect.GetAll();

            var viewModel = new ManagementIndexViewModel<ImperfectViewModel>();

            if (imperfectWords.IsSuccess)
            {
                viewModel.Entities = _mapper.Map<List<ImperfectViewModel>>(imperfectWords.DataList);
                viewModel.IsSuccess = true;
            }
            else
            {
                viewModel.IsSuccess = false;
            }

            return View(viewModel);
        }

        [HttpGet]
        [Route("[controller]/[action]")]
        public IActionResult CreateImperfect()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> CreateImperfect(ImperfectViewModel newImperfect)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Imperfect>(newImperfect);

                _unitOfWork.Imperfect.Create(entity);

                await _unitOfWork.Save();

                return RedirectToAction("DisplayImperfects");
            }
            return View(newImperfect);
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}", Name = "ImperfEdit")]
        public async Task<IActionResult> EditImperfect(int? id)
        {
            var currentWord = await _unitOfWork.Imperfect.GetSingle(w => w.Id == id);

            if(!currentWord.IsSuccess)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<ImperfectViewModel>(currentWord.Data);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]/{id}", Name = "ImperfEdit")]
        public async Task<IActionResult> EditImperfect(ImperfectViewModel editedImperf)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Imperfect>(editedImperf);

                _unitOfWork.Imperfect.Update(entity);

                await _unitOfWork.Save();

                return RedirectToAction("DisplayImperfects");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}", Name = "ImperfDelete")]
        public async Task<IActionResult> DeleteImperfect(int? id)
        {
            var currentWord = await _unitOfWork.Imperfect.GetSingle(w => w.Id == id);

            if(currentWord == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<ImperfectViewModel>(currentWord);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/DeleteImperfect/{id}", Name = "ImperfDelete")]
        public async Task<IActionResult> DeleteImperfectAction(int? id)
        {
            var wordToDelete = await _unitOfWork.Imperfect.GetSingle(w => w.Id == id);

            if (!wordToDelete.IsSuccess)
            {
                return NotFound();
            }

            _unitOfWork.Imperfect.Delete(wordToDelete.Data);
            await _unitOfWork.Save();

            return RedirectToAction("DisplayImperfects");
        }

        #endregion
    }
}
