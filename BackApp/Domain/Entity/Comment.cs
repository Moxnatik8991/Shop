namespace Shop.BackApp.Domain.Entity
{
    public class Comment : BaseEntity
    {
        public string FirstName { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }
        public Guid ProductId { get; set; }
    }
}
