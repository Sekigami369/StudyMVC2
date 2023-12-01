using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMVC2.Data;

namespace StudyMVC2.Controllers
{
    public class LoginsController : Controller
    {
        public readonly StudyMVC2Context _context;
        public LoginsController(StudyMVC2Context context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> VerificationAsync()
        {
            return _context.Photos != null ?
               View(await _context.Logins.ToListAsync()) :
               Problem("Entity set 'Study.Photos' is null.");
        }
    }
}
