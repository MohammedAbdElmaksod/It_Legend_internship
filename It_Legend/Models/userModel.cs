using System.ComponentModel.DataAnnotations;

namespace It_Legend.Models
{
    public class userModel
    {
        public string? FullName { get; set; }
        [Required(ErrorMessage ="Pleasse Enter Your E-mail ")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Please Enter Your Password")]
        public string? Password { get; set; }
        public string? CompanyName { get; set; }
        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage ="you should accept our Terms to signup")]
        public bool? AcceptedTerms { get; set; } = false;
        public string? returnUrl { get; set; }
    }
}
