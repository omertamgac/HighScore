using System.ComponentModel.DataAnnotations;

namespace HightScore.Models
{
    public class EditVM
    {

        public string? Id { get; set; }
        public string? UserName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Parola Eşleşmiyor")]
        public string? ConfirmPassword { get; set; }

        public string? Phone { get; set; }
    }
}
