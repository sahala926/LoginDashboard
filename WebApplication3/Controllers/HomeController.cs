using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //var message = _context.Home.FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Index(HomeModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            
            var home = new Home
            {
                MessageText = model.text
            };

            _context.Home.Add(home);
            _context.SaveChanges();

            
            return RedirectToAction("Text", "Text");
        }
       


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
