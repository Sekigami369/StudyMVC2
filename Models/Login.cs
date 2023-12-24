using System.ComponentModel.DataAnnotations;

namespace StudyMVC2.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage ="UserNameは必須です。")]
        public string UserName { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "PassWordは必須です。")]
        public string Password { get; set; }
    }
}
