using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.BackApp.Domain.Entity
{
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime DataCreate { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}
