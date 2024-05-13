using Doan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
			var categories = _context.Category.ToList();
			var id = 0;
			if (!request.ContainsKey("category")) id = categories[0].id;
			else id = int.Parse(request["category"]);

			var products = _context.Products.Where(n => n.Category_id == id).ToList();
			ViewBag.categories = categories;
			return View(products);
		}
		//[Route("/details/")]
		public IActionResult Details(int id)
		{
			var cc = _context.Products.FirstOrDefault(p =>p.Id == id) ;
		
				if (cc == null)
				{
					return NotFound();
				}
			return View(cc);
			
		}
		
		
	}
}
