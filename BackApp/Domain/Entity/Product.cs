namespace Shop.BackApp.Domain.Entity;
public class Product : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public uint CountViews { get; set; } = uint.MinValue;
    public uint CountComments { get; set; } = uint.MinValue;
    public decimal Rating { get; set; } = 0;
    public Guid CategoryId { get; set; }
    public Guid UserId { get; set; }

    public List<Comment>? Comments { get; set; }
    public List<ProductFileDetailse>? Files { get; set; }
}
