using Doan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doan.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public ContactController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }       

        public IActionResult Index()
        {
            return View();
        }
    }
}
