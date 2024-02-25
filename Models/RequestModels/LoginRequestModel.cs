using System.ComponentModel.DataAnnotations;

namespace Shop.Models.RequestModels
{
    public class LoginRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
