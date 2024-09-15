using Microsoft.AspNetCore.Mvc;
using LanguagePractice.Repositories.IRepositories;
using AutoMapper;
using LanguagePractice.Models.ViewModels;
using LanguagePractice.Common.Result;

namespace LanguagePracticeSite.Areas.User.Controllers
{
    [Area("User")]
    public class ItalianController : Controller
    {
        private readonly IItalianRepository _italianRepository;
        private readonly IMapper _mapper;

        public ItalianController(IItalianRepository italianRepository, IMapper mapper)
        {
            _italianRepository = italianRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[Controller]/[Action]")]
        public async Task<IActionResult> PresentIndicative()
        {
            var retrievedPresIndWord = await _italianRepository.GetPresentIndicative();

            var viewModel = _mapper.Map<PresentIndicativeViewModel>(retrievedPresIndWord);

            return View(viewModel);
        }

        [HttpGet]
        [Route("[Controller]/[Action]")]
        public async Task<IActionResult> PresentPerfect()
        {
            var retrievedPresPerfWord = await _italianRepository.GetPresentPerfect();

            var viewModel = _mapper.Map<PresentPerfectViewModel>(retrievedPresPerfWord);

            return View(viewModel);
        }

        [HttpGet]
        [Route("[Controller]/[Action]")]
        public async Task<IActionResult> Imperfect()
        {
            var result = await _italianRepository.GetImperfect();

            var viewModel = new ImperfectViewModel();

            if (result.IsSuccess)
            {
                viewModel = _mapper.Map<ImperfectViewModel>(result.Data);
                viewModel.IsSuccess = true;
            }
            else
            {
                viewModel.IsSuccess = false;
                viewModel.ErrorMessage = result.ErrorMessage;
            }

            return View(viewModel);
        }
    }
}
