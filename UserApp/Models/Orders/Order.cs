using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace UserApp.Models.Orders;
public class Order : BaseEntity
{
    [Key]
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public int TotalAmount { get; set; }
    public string? Status { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? Users { get; set; }
}
