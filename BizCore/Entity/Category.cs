using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Category : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryId { get; init; }

    [StringLength(50)]
    public string CategoryName { get; init; }

    [Column(TypeName = "TEXT")]
    public string Description { get; init; }
}