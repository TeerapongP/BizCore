using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity
{
    public class Accounts : BaseEntity
    {
        // Marks AccountId as the primary key and auto-increments
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; init; }

        // Specifies the maximum length for AccountName
        [StringLength(255)] 
        public string AccountName { get; init; }

        // Specifies the maximum length for AccountType
        [StringLength(50)] 
        public string AccountType { get; init; }

        // Defines the Balance column with precision 15 and scale 2
        [Column(TypeName = "decimal(15, 2)")] 
        public decimal Balance { get; init; }
    }
}