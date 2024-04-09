using System.ComponentModel.DataAnnotations;

namespace Shop.BackApp.Models.RequestModels
{
    public class ProductRequestModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public List<IFormFile>? Files { get; set; }
    }
}
