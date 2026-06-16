using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserApp.Models;

public class User: BaseEntity
{
    [Key]
    public int UserId { get; set; }
    [Required]
    public string? UserName { get; set; }
    [Required]
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int PhoneNumber { get; set; }
    public string? Address { get; set; }
}
