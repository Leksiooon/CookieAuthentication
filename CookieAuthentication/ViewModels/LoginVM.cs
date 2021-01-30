using System.ComponentModel.DataAnnotations;

namespace CookieAuthentication.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Login jest wymagany!")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
