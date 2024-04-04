namespace Shop.BackApp.Domain.Entity
{
    public class CategoryFileDetails : FileDetails
    {
        public Guid? CategoryId { get; set; }

        public void Update(CategoryFileDetails newFile)
        {
            this.Name = newFile.Name;
            this.Path = newFile.Path;
            this.Extension = newFile.Extension;
            this.DataUpdate = DateTime.UtcNow;
        }
    }
}
