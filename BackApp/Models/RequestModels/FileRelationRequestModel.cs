using Shop.BackApp.Domain.Entity;

namespace Shop.BackApp.Models.RequestModels
{
    public class FileRelationRequestModel
    {
        public Guid FileId { get; set; }
        public int Order { get; set; }

        public FileRelation MapToDomain(string entityName, Guid entityId)
        {
            return new FileRelation 
            {  
                FileId = FileId, 
                Order = Order, 
                EntityId = entityId,
                EntityName = entityName
            };
        }
    }
}
