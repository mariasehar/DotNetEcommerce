using Microsoft.AspNetCore.Mvc;
using UserApp.Data;
using UserApp.Models.Categories;

namespace UserApp.Controllers;

public class CategoriesController : Controller
{
    private readonly AppDbContext _context;

    public CategoriesController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(category);
    }
    [HttpGet]

    public IActionResult Edit(int CategoryId)
    {
        var category = _context.Categories.Find(CategoryId);

        if (category == null)
            return NotFound();

        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(category);
    }
    [HttpGet]
    public IActionResult Delete(int CategoryId)
    {
        var category = _context.Categories.Find(CategoryId);

        if (category == null)
            return NotFound();

        return View(category);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteConfirmed(int CategoryId)
    {
        var category = _context.Categories.Find(CategoryId);

        if (category == null)
            return NotFound();

        _context.Categories.Remove(category);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
