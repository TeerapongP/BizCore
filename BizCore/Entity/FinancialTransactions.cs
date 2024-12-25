using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class FinancialTransactions: BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TransactionId { get; init; }
    
    // Navigation property for the related Account
    [ForeignKey("AccountId")]
    public Accounts Account { get; init; }
    
    public DateTime TransactionDate { get; init; }
    
    [Column(TypeName = "decimal(15, 2)")] 
    public decimal Amount { get; init; }
    
    [StringLength(50)]
    public string TransactionType { get; init; }
    
    [Column(TypeName = "TEXT")]  // Specifies that the Description is a TEXT type in the database
    public string Description { get; init; }
}