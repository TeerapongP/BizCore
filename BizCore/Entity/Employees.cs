using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Employees:BaseEntity
{
    // Marks EmployeeId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EmployeeId { get; init; } 
    
    [StringLength(50)]
    public string FirstName { get; init; }
    
    [StringLength(50)]
    public string LastName { get; init; }
    
    [StringLength(50)]
    public string Position { get; init; }
    
    public DateTime HireDate { get; init; }
    
    // Defines the Balance column with precision 15 and scale 2
    [Column(TypeName = "decimal(15, 2)")] 
    public decimal Salary { get; init; }
    
    [StringLength(50)]
    public string Department { get; init; }
    
    public int? ManagerId { get; init; }
    
    public bool Status { get; init; }
}