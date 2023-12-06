using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMVC2.Data;
using StudyMVC2.Models;
using System.Diagnostics;
using System.Security.Cryptography;

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

        [HttpPost]
        public IActionResult Login(Login login)
        {



            return View(login);
        }


        private bool IsValidCheckUser(string loginID,  string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {

                return true;
            }
            return false;

            //ログインの検証方法をここに書く

        }

    }
}
