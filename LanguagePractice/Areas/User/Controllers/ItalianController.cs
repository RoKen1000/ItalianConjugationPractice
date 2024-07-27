using Microsoft.AspNetCore.Mvc;
using LanguagePractice.Repositories.IRepositories;

namespace LanguagePracticeSite.Areas.User.Controllers
{
    [Area("User")]
    public class ItalianController : Controller
    {
        private readonly IItalianRepository _italianRepository;

        public ItalianController(IItalianRepository italianRepository)
        {
            _italianRepository = italianRepository;
        }

        [HttpGet]
        [Route("[Controller]/[Action]")]
        public async Task<IActionResult> PresentIndicative()
        {
            var retrievedPresIndWord = await _italianRepository.GetPresentIndicative();

            return View(retrievedPresIndWord);
        }

        [HttpGet]
        [Route("[Controller]/[Action]")]
        public async Task<IActionResult> PresentPerfect()
        {
            var retrievedPresPerfWord = await _italianRepository.GetPresentPerfect();

            return View(retrievedPresPerfWord);
        }

        [HttpGet]
        [Route("[Controller]/[Action]")]
        public async Task<IActionResult> Imperfect()
        {
            var retrievedImperfectWord = await _italianRepository.GetImperfect();

            return View(retrievedImperfectWord);
        }
    }
}
