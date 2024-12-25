using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class Machines:BaseEntity
{
    // Marks MachineId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MachineId { get; init; }
    
    [StringLength(255)]
    public string MachineName { get; init; }
    
    [StringLength(50)]
    public string MachineType { get; init; }
    
    public bool Status { get; init; }
    
    public DateTime LastMaintenanceDate { get; init; }
}