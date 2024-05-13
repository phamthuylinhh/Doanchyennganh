using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Doan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;
        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public List<Products> Product()
        {
            var products = (from p in _context.Products/*.Where(m => m.product_category_id == 1) */select p).ToList();
            return products;
        }
        

        public IActionResult Privacy()
        {
            return View();
        }
        public class LogoutController : Controller
        {
            public IActionResult Index()
            {
                Functions._UserID = 0;
                Functions._UserName = string.Empty;
                Functions._Email = string.Empty;
                Functions._Message = string.Empty;
                Functions._MessageEmail = string.Empty;


                //return RedirectToAction("Index", "Home");
                return RedirectToAction("Index", "home", new { area = "" }); // is true

            }
        }




    }
}
