using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorPagesProject.Models
{
    public class CredentialsViewModel
    {
        [Required(ErrorMessage = "Please enter your e-mail address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
