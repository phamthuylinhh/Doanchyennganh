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


		//[Route("/product/")]
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
		
		[Route("/product/details/{id}")]
		public IActionResult Details(int id)
		{
          
            var cc = _context.Products.FirstOrDefault(p =>p.Id == id) ;
		
				if (cc == null)
				{
					return NotFound();
				}
				var sizes = _context.Product_size.ToList();
				var details = _context.ProductDetails.Where(p=>p.Products_id == id).ToList();
			ViewBag.Sizes = sizes;
			ViewBag.Product = cc;
			ViewBag.Details = details;
			return View(cc);
			
		}
        [HttpPost]
        public IActionResult AddToCart(int productId, int sizeId, int quantity)
        {
            // Find the product and size
            var product = _context.Products.Find(productId);
            var size = _context.Product_size.Find(sizeId);
           
            if (product == null || size == null)
            {
                return NotFound();
            }
		
            // Create a new entry in Product_Details
            var details = new ProductDetails
            {
                Products_id = productId,
                Size_id = sizeId,
                Quantity = quantity
            };

            _context.ProductDetails.Add(details);
            _context.SaveChanges();

            return RedirectToAction("Details", new { id = productId });
        }
    }
}
		
	