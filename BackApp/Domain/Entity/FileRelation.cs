using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Shop.BackApp.Domain.Entity;

public class FileRelation
{
    public string EntityName { get; set; }
    public Guid EntityId { get; set; }
    public Guid FileId { get; set; }
    public int Order {  get; set; }

    [Required]
    public FileDetails File { get; set; } = null!;
}

