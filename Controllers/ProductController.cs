using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "login");

            var cc = _context.Products.FirstOrDefault(p => p.Id == id);

            if (cc == null)
            {
                return NotFound();
            }
            var sizes = _context.Product_size.ToList();
            var details = _context.ProductDetails.Where(p => p.Products_id == id).ToList();
            ViewBag.Sizes = sizes;
            ViewBag.Product = cc;
            ViewBag.Details = details;
            var relatedProducts = _context.Products
                .Where(p => p.Contents == cc.Contents && p.Id != id)
                .Take(3)
                .ToList();

            if (relatedProducts != null)
            {
                ViewBag.RelatedProducts = relatedProducts;
            }
            else
            {
                ViewBag.RelatedProducts = new List<Products>();
            }
            return View(cc);

        }
        [HttpPost]
        public IActionResult AddToCart(int productId, int sizeId, int quantity)
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "login");
            var product = _context.Products.Find(productId);
            var size = _context.Product_size.Find(sizeId);

            if (product == null || size == null)
            {
                return NotFound();
            }

           
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

