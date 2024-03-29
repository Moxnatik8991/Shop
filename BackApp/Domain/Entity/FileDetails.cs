namespace Shop.BackApp.Domain.Entity
{
    public class FileDetails : BaseEntity
    {
        public FileDetails()
        {
            Id = Guid.NewGuid();
            DataCreate = DateTime.UtcNow;
            DataUpdate = DateTime.UtcNow;
        }

        public string Name { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
    }
}
