using System.ComponentModel.DataAnnotations;

namespace pd311_mvc_aspnet.ViewModels
{
    public class RegisterVM 
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(18, 100, ErrorMessage = "Вік має бути від 18 до 100 років")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
