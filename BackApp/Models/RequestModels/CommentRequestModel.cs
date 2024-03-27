using System.ComponentModel.DataAnnotations;

namespace Shop.BackApp.Models.RequestModels
{
    public class CommentRequestModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public Guid ProductId { get; set; }
    }
}
