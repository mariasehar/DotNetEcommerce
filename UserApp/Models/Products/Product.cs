using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UserApp.Models.Categories;

namespace UserApp.Models.Products;
public class Product:BaseEntity
{
    [Key]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Please select a category")]

    public int? CategoryId { get; set; }
    [Required]
    public string? ProductName { get; set; }
    public string? ImageUrl { get; set; }
    public string? ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string? Stock { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public virtual Category? Category { get; set; }
}
