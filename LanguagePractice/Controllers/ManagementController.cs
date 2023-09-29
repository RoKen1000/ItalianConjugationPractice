using LanguagePractice.DataAccess.DataContext;
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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
