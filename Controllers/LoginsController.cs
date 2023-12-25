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
            var authentication_Name = await _context.Logins
                .FirstOrDefaultAsync(m => m.UserName == inputUserName);

            if (inputUserName == null || inputPassword == null)
            {
                return BadRequest("ユーザー名または、パスワードが入力されていません。");
            }

            if (authentication_Name == null)
            {
                return Unauthorized("ユーザー名または、パスワードが正しくありません。");
            }


            var hashedPassword = HashPassWord(inputPassword);//saltはハッシュ化するときの値

            if (hashedPassword == authentication_Name.Password)
            {
                return View("Welcome");
            }


            return Unauthorized("ユーザー名またはパスワードが正しくありません。");

        }


        private string HashPassWord(string inputPassword)
        {
            //入力kされた平文のパスワードをハッシュ化して認証用のメソッドに渡す

            //平文のパスワードをハッシュ化する
            var hashedPassword = (inputPassword)

            return hashedPassword;

        }
       
    }
}
