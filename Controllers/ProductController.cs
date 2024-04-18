using Doan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doan.Controllers
{
	public class ProductController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataContext _context;

		public ProductController(ILogger<HomeController> logger, DataContext context)
		{
			_logger = logger;
			_context = context;
		}

		[Route("/product/")]
		public IActionResult Index(Dictionary<string, string> request)
		{

			var s = _context.Category.ToList();
			ViewBag.Category = s[0].id;	
			return View(s);
        }
        [Route("/product/{id:int}")]
        public IActionResult Index(int id)
        {
            var s = _context.Category.ToList();
            ViewBag.Category = id;
            return View(s);
        }
        [Route("/product_get/{id:int}")]
        public IActionResult product_get(int Id)
		{
			var listProduct = _context.Products.Where(n => n.Category_id == Id).ToList();
			return Ok(listProduct);
		}
	}
}
