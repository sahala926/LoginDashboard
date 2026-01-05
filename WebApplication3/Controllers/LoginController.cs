using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class LoginController : Controller 
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginModel model) 
        {
            //var x = _context.Login.ToList();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = (from a in _context.Login
                        where a.name == model.username &&
                            a.password == model.password
                        select a).FirstOrDefault();

            


            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid email or password";
            return View(model);
        }
    }
}