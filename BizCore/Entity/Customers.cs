using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Customers:BaseEntity
{
    // Marks CustomersId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustomersId { get; init; }
    
    [StringLength(50)]
    public string CustomerName { get; init; }
    
    [StringLength(100)]
    public string ContactName { get; init; }
    
    [StringLength(20)]
    public string PhoneNumber { get; init; }
    
    [StringLength(50)]
    public string Email { get; init; }
    
    [StringLength(255)]
    public string Address { get; init; }
}