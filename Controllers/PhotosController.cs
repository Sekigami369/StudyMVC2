using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMVC2.Data;
using StudyMVC2.Models;


namespace StudyMVC2.Controllers
{
    public class PhotosController : Controller
    {
        public readonly StudyMVC2Context _context;

        public PhotosController(StudyMVC2Context context)
        {
            _context = context;
        }


        public IActionResult Show()
        {
            return View();
        }

        public async Task<IActionResult> IndexList()
        {
            return _context.Photos != null ?
                View(await _context.Photos.ToListAsync()) :
                Problem("Entity set 'Study.Photos' is null.");
        }

    }
}
