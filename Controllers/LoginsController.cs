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

       
        public IActionResult IsValidCheckUser(string loginID,  string password)
        {
            if()
            {
                return RedirectToAction("Success");
            }
        }

        private async bool LoginIsValid(String UserName,  String Password)
        {
            try
            {


                var login = await  _context.Logins.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

            }
        }

        /*
         * ChatGPDから参考資料として張り付けてある
         * 
         * ログイン失敗時と成功時の処理が書いてある
         * 
         * IDとPassが違ったらエラーメッセージをErrorBagで表示したい
         * 
        if (person == null)
    {
        ViewBag.ErrorMessage = "Invalid username or password";
        return View("Login"); // ログイン画面に戻るなどの処理
    }

    // ログイン成功の処理
    return RedirectToAction("Index", "Home");
        */


    }
}
