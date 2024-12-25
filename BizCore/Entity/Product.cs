using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Product:BaseEntity
{
    // Marks ProductId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProductId { get; init; }
    
    public string ProductName { get; init; }
    
    
    // Navigation property for the related Category
    [ForeignKey("CategoryID")]
    public Category Category { get; init; }
    
    
    public int StockQuantity { get; init; }
    
    // SupplierID
    // Navigation property for the related Category
    [ForeignKey("SupplierId")]
    public Supplier Supplier { get; init; }
    
    [StringLength(255)]
    public string WarehouseLocation { get; init; }
}