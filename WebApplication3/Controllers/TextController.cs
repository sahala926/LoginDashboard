using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
namespace WebApplication3.Controllers
{
    public class TextController : Controller
    {
        private readonly AppDbContext _context;

        public TextController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Text()
        {            
            var message = _context.Text.FirstOrDefault();
            return View(message);
        }
    }
}
