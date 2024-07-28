using System.ComponentModel.DataAnnotations;
namespace Entity;
public class BaseEntity
{
    [Key]
    public Guid ID { get; set; }
}