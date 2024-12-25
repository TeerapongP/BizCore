using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class MachineAndMaintenance:BaseEntity
{
    // Marks MaintenanceId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaintenanceId { get; init; }
    
    // Navigation property for the related Machines
    [ForeignKey("MachineId")]
    public virtual Machines Machines { get; init; }
    
    public DateTime MaintenanceDate { get; init; }
    
    public string MaintenanceType { get; init; }
    
    public bool Status { get; init; }
}