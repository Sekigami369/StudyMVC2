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

              
        private async Task<IActionResult> IsValidCheckUser(string inputUserName, string inputPassword)
        {
            var authentication_Name = _context.Logins
                .FirstOrDefaultAsync(m => m.UserName == inputUserName);

            if (inputUserName == null || inputPassword == null)
            {
                return BadRequest("ユーザー名または、パスワードが入力されていません。"); 
            }
            var hashedPassword = HashPassWord(inputPassword, User.Salt);//saltはハッシュ化するときの値
            {
                return View("Welcome");
            }
           
            return View();
        }


        private string HashPassWord(string inputPassword , string salt)
        {
            //入力kされた平文のパスワードをハッシュ化して認証用のメソッドに渡す

            var hashedPassword = 

            return hashedPassword;

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
