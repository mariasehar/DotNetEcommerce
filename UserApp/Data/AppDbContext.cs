using Microsoft.EntityFrameworkCore;
using UserApp.Models;
using UserApp.Models.Categories;
using UserApp.Models.OrderLineItems;
using UserApp.Models.Orders;
using UserApp.Models.Products;


namespace UserApp.Data;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderLineItem> OrderItems { get; set; }







}
