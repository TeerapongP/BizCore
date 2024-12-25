using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Supplier:BaseEntity
{
    // Marks SupplierId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SupplierId { get; init; }
    
    [StringLength(50)]
    public string SupplierName { get; init; }
    
    [StringLength(50)]
    public string ContactName { get; init; }
    
    [StringLength(20)]
    public string PhoneNumber { get; init; }
    
    [StringLength(255)]
    public string Address { get; init; }
    
    // Navigation property for the related Category
    [ForeignKey("CategoryID")]
    public Category Category { get; init; }
}