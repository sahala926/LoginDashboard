using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class RegisterModel
    {
        public string username { get; set; }

        [EmailAddress(ErrorMessage = "invalid email format")]
        public string email { get; set; }

        [MinLength(8, ErrorMessage = "minimum 8 character required")]
        public string password { get; set; }

        [Compare("password", ErrorMessage = "the password does not match")]

        public string confirmpassword { get; set; }
    }
}
