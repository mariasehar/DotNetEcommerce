using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UserApp.Models.Orders;
using UserApp.Models.Products;

namespace UserApp.Models.OrderLineItems;
public class OrderLineItem:BaseEntity
{
    [Key]
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Qunatity { get; set; }
    public int Price { get; set; }

    [ForeignKey(nameof(OrderId))]
    public virtual Order Orders { get; set; }
    [ForeignKey(nameof(ProductId))]
    public virtual Product Product { get; set; }
}
