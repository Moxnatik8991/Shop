using System.ComponentModel.DataAnnotations;

namespace Shop.BackApp.Models.RequestModels
{
    public class LoginRequestModel
    {
        /// <example>admin@admin.com</example>
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        /// <example>qwe123</example>
        [Required]
        public string Password { get; set; }
    }
}
