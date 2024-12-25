using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Orders:BaseEntity
{
    
    // Marks OrdersId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrdersId { get; init; }
    
    // Navigation property for the related Category
    [ForeignKey("CustomerID")]
    public virtual Category Category { get; init; }
    
    public DateTime OrderDate { get; init; }
    
    // Defines the Balance column with precision 15 and scale 2
    [Column(TypeName = "decimal(15, 2)")] 
    public decimal TotalAmount { get; init; }
    
    [StringLength(50)]
    public string OrderStatus { get; init; }
    
    [StringLength(255)]
    public string ShippingAddress { get; init; }
    
    [StringLength(50)]
    public string PaymentMethod { get; init; }
}