using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Doan.Controllers
{
	public class CartController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataContext _context;

		public CartController(ILogger<HomeController> logger, DataContext context)
		{
			_logger = logger;
			_context = context;
		}
    
        public IActionResult Index(Dictionary<string, string> request)
        {
            var userId = Functions._UserID; // Lấy user_id của người dùng
            var cart = _context.Cart.Where(m => m.User_id == Functions._UserID).Select(m => new
            {
                Cart = m,
                Products = _context.Products.Where(p => p.Id == m.Product_id).FirstOrDefault(),

            }).ToList();
            return View(cart);

        }

        [HttpPost]
        public ActionResult AddToCart(int product_id, int quantity)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == product_id) ;
            
            if (product == null)
            {
                return NotFound();
            }
           int price =(int)(product.Price * quantity);
            var order = new Cart
            {
                User_id = Functions._UserID,
                
                Product_id = product_id,
                Quantity = quantity,
                Price = price,
                Order_status = "Pending",
            };
            _context.Add(order);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var cc = _context.Cart.Where( m=> m.Cart_id == id && Functions._UserID == m.User_id).FirstOrDefault();
            if (cc == null)
            {
                return NotFound();
            }
            return View(cc);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var db = _context.Cart.Where(m => m.Cart_id == id && Functions._UserID == m.User_id).FirstOrDefault();
            if (db == null)
            {
                return NotFound();
            }
            _context.Cart.Remove(db);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
