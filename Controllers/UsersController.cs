using Microsoft.AspNetCore.Mvc;
using mvcOne.Data;
using mvcOne.Models;

namespace mvcOne.Controllers
{
    public class UsersController : Controller
    {
        AppDbContext context = new AppDbContext();

        public IActionResult Index()
        {
            var user = context.Users.ToList();
            return View(user);
        }
            public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Login");

        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
        var success = context.Users.Any(x => x.UserName == user.UserName && x.Password == user.Password);
           if (success)
            {
                return RedirectToAction("Index", "Employees");
            }
           else
            {
              
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(user); 
            }

        }
        [HttpPost]
        public IActionResult ToggleUserActivation(Guid userId)
        {
            var user = context.Users.Find(userId);
            if (user != null)
            {
                user.IsActive = !user.IsActive;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }



    }
}
