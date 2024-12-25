using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCore.Entity;

public class User:BaseEntity
{
    // Marks UserId as the primary key and auto-increments
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; init; }
    
    [StringLength(50)]
    public string UserName { get; init; }
    
    [StringLength(50)]
    public string Password { get; init; }
    
    [StringLength(50)]
    public string FirstName { get; init; }
    
    [StringLength(50)]
    public string LastName { get; init; }
    
    [StringLength(100)]
    public string Email { get; init; }
    
    [StringLength(20)]
    public string Role { get; init; }
    
    public bool Status { get; init; }
}