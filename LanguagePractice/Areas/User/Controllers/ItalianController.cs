using LanguagePractice.DataAccess.DataContext;
using LanguagePracticeSite.Models;
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

        [Route("[Controller]/[Action]")]
        public IActionResult PresentIndicative()
        {
            PresentIndicative retrievedWord = _italianRepository.PresentIndicative();

            return View(retrievedWord);
        }

        [Route("[Controller]/[Action]")]
        public IActionResult PresentPerfect()
        {
            PresentPerfect retrievedWord = _italianRepository.PresentPerfect();

            return View(retrievedWord);
        }

        [Route("[Controller]/[Action]")]
        public IActionResult Imperfect()
        {
            Imperfect retrievedWord = _italianRepository.Imperfect();

            return View(retrievedWord);
        }
    }
}
