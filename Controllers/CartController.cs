using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

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
        public async Task<IActionResult> Index(Dictionary<string, string> request)
        {
            if (!Functions.IsLogin())
            {
                Redirect(nameof(Index));
            }
            var userId = Functions._UserID; // Lấy user_id của người dùng
            var cart = _context.Cart.Where(m => m.User_id == Functions._UserID).Select(m => new
            {
                Cart = m,
                Products = _context.Products.Where(p => p.Id == m.Product_id).FirstOrDefault(),
                Product_size = _context.Product_size.Where(p => p.Id == m.Size_id).FirstOrDefault(),

            }).ToList();
            return View(cart);
        }
        [HttpPost]
        public ActionResult AddToCart(Cart cart)
        {
            if (!Functions.IsLogin())
            {
                Redirect(nameof(Index));
            }
            var product = _context.Products.Find(cart.Product_id);
            cart.Price = product.Price * cart.Quantity;
            var item = _context.Cart.FirstOrDefault(m => m.Product_id == cart.Product_id && m.Size_id == cart.Size_id && m.User_id == Functions._UserID);
            if(item == null) { 
                _context.Cart.Add(cart);
            }
            else
            {
                item.Quantity += cart.Quantity;
                _context.Cart.Update(item);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("/cart/del/{productid}/{product_size_id}")]
        public async Task<IActionResult> Delete(int productid, int product_size_id)
        {
            var cc = _context.Cart.Where(m => Functions._UserID == m.User_id && m.Product_id == productid && m.Size_id == product_size_id).FirstOrDefault();
            if (cc == null)
            {
                return RedirectToAction("Index");
            }
            _context.Cart.Remove(cc);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateQuantity( int quantity)
        {
            var userID = Functions._UserID;
            var cartItem = _context.Cart.Where(m => m.User_id == Functions._UserID).FirstOrDefault();
            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
                cartItem.Price = cartItem.Price * quantity;
                _context.Cart.Update(cartItem);
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}
