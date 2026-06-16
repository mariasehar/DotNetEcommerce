using System.ComponentModel.DataAnnotations;

namespace UserApp.Models.Categories;

public class Category:BaseEntity
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string? CategoryName { get; set; }
    public string? Description { get; set; }
}
