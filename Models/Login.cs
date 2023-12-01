using System.ComponentModel.DataAnnotations;

namespace StudyMVC2.Models
{
    public class Login
    {
        public int UserId { get; set; }
        
        [Required(ErrorMessage = "ユーザーネームを入力してください。")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "パスワードを入力してください。")]
        public string Password { get; set; }
    }
}
