using System.ComponentModel.DataAnnotations;

namespace API.Dto
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"((?=.*\d)(?=.*[A-Z]).{8,50})", ErrorMessage = "Password must have 1 Uppercase, 1 Lowercase, 1 Number, 1 Non Alphanumeric and at least 8 characters")]
        public string Password { get; set; }
    }
}