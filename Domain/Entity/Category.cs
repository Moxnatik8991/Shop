using Shop.Abstractions;

namespace Shop.Domain.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public Guid? CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
