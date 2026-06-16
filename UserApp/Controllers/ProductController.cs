using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserApp.Data;
using UserApp.Models.Products;

public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult ProductIndex()
    {
        var products = _context.Products
            .Include(p => p.Category)
            .ToList();

        return View(products);
    }

    public IActionResult CreateProduct()
    {
        ViewBag.Categories = _context.Categories.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("ProductIndex");
        }

        ViewBag.Categories = _context.Categories.ToList();
        return View(product);
    }

    public IActionResult EditProduct(int id)
    {
        var product = _context.Products.Find(id);
        ViewBag.Categories = _context.Categories.ToList();
        return View(product);
    }

    [HttpPost]
    public IActionResult EditProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return RedirectToAction("ProductIndex");
        }

        ViewBag.Categories = _context.Categories.ToList();
        return View(product);
    }

    [HttpGet]
    public IActionResult DeleteProduct(int id)
    {
        var product = _context.Products.Find(id);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    [HttpPost]
    public IActionResult DeleteProduct(Product product)
    {
        var existingProduct = _context.Products.Find(product.ProductId);

        if (existingProduct != null)
        {
            _context.Products.Remove(existingProduct);
            _context.SaveChanges();
        }

        return RedirectToAction("ProductIndex");
    }
}