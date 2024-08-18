using System.ComponentModel.DataAnnotations;

namespace HighScore.Models
{
    public class ResetPasswordVM
    {
        public string Token { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords is not same")]
        public string ConfirmPassword { get; set; }
    }
}
