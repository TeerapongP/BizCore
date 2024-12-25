using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Production:BaseEntity
{
    // Marks ProductionOrderId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductionOrderId { get; init; }
    
    // Navigation property for the related Employees
    [ForeignKey("EmployeeID")]
    public Employees Employees { get; init; }
    
    public int Quantity { get; init; }
    
    public DateTime ProductionDate { get; init; }
    
    public bool Status { get; init; }
    
    // Navigation property for the related Machines
    [ForeignKey("MachineID")]
    public Machines Machines { get; init; }
}