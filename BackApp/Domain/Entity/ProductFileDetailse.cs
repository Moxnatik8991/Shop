namespace Shop.BackApp.Domain.Entity
{
    public class ProductFileDetailse : FileDetails 
    {
        public Guid? ProductId { get; set; }

        public byte Order { get; set; } = byte.MinValue;
    }
}
