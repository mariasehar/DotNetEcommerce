using Microsoft.AspNetCore.Mvc;
using UserApp.Data;
using UserApp.Models;
using UserApp.Models.Categories;


namespace UserApp.Controllers
{
    public class UserController : Controller
    {
        public readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult UserIndex()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult CreateUser(){
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("UserIndex");
            }

            return View(user);

        }
        }

}
