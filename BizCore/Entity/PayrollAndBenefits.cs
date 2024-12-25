using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BizCore.Entity;

public class PayrollAndBenefits:BaseEntity
{
    // Marks ProductId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; init; } 
    
    // Navigation property for the related Employees
    [ForeignKey("EmployeeID")]
    public Employees Employees { get; init; }
    
    // Defines the Balance column with precision 15 and scale 2
    [Column(TypeName = "decimal(15, 2)")] 
    public int TaxAmount { get; init; }
    
    // Defines the Balance column with precision 15 and scale 2
    [Column(TypeName = "decimal(15, 2)")] 
    public decimal BenefitsAmount { get; init; }
    
    // Defines the Balance column with precision 15 and scale 2
    [Column(TypeName = "decimal(15, 2)")] 
    public decimal BonusAmount {get; init; }
    
    public DateTime PaymentDate { get; init; }
    
    public bool Status { get; init; }
    
    // Defines the Balance column with precision 15 and scale 2
    [Column(TypeName = "decimal(15, 2)")] 
    public decimal SalaryAmount { get; init; }
}