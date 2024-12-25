using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class FinancialReports:BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReportId { get; init; }
    
    [StringLength(50)]
    public string ReportType { get; init; }
    
    public DateTime ReportDate { get; init; }
    
    public string GeneratedBy { get; init; }
    
    public DateTime GeneratedDate { get; init; }
    
    [Column(TypeName = "decimal(15, 2)")] 
    public double TotalRevenue { get; init; }
    
    [Column(TypeName = "decimal(15, 2)")] 
    public double TotalExpenses { get; init; }
    
    [Column(TypeName = "decimal(15, 2)")] 
    public double NetProfit { get; init; }
}