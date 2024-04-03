namespace Shop.BackApp.Domain.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public Guid? CategoryId { get; set; }
        public List<Category>? Categories { get; set; }


        
        public List<FileRelation>? FileRelations { get; set; }
    }
}
