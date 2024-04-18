using System.ComponentModel.DataAnnotations;

namespace Shop.BackApp.Models.RequestModels
{
    public class RestoreAccessTokenRequestModel
    {
        [Required]
        public string AccessToken { get; set; }

        [Required]

        public string RefreshToken { get; set; }
    }
}
