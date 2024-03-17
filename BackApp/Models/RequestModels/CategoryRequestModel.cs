using System.ComponentModel.DataAnnotations;

namespace Shop.BackApp.Models.RequestModels
{
    public class CategoryRequestModel
    {
        [Required]
        public string Name { get; set; }

        public Guid? CategoryId { get; set; } = null;
    }
}
