using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Doan.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public CheckoutController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var userId = Functions._UserID;
            var cart = _context.Cart.Where(m => m.User_id == userId).ToList();
            decimal TotalAmount = 0;
            foreach(var item in cart)
            {
                TotalAmount +=Convert.ToDecimal(item.Price);
            }
            var paymethod = (from m in _context.Pay_method
                            select new SelectListItem()
                            {
                                Value = m.Id.ToString(),
                                Text = m.Name,
                            }).ToList();
            return View((_context.User.FirstOrDefault(m => m.Id == userId), TotalAmount, paymethod));
        }
        [HttpPost]
        public IActionResult Checkout(string name,string address,string phone, int paymethodid)
        {

            var userId = Functions._UserID;
            var cart = _context.Cart.Where(M => M.User_id == userId).ToList();
            if (cart == null)
            {
                return RedirectToAction("Index");
            }
            var id = DateTime.Now.ToString("yyyyMMddhhmmss") + "_" + userId.ToString();
            foreach (var item in cart)
            {
                var order = new Order()
                {
                    Id = id,
                    User_id = userId,
                    ProductID = item.Product_id,
                    ProductSizeID = item.Size_id,
                    Quantity = item.Quantity,
                    Price = (decimal)(item.Price ?? 0),
                    Address = address,
                    Oder_status = "Paid",
                    Pay_method_id = paymethodid,
                    Phone = phone,
                    Name = name
                };
                _context.Order.Add(order);
            }
            _context.Cart.RemoveRange(cart);
            _context.SaveChanges();

            return RedirectToAction("Index" ,"History");
        }
        [HttpGet]
        [Route("/history")]
        public IActionResult History() 
        { 
            var orderr = _context.Order.Where(m => m.User_id == Functions._UserID).Select(m => new
            {
                Order = m,
                Products = _context.Products.Where(p => p.Id == m.ProductID).FirstOrDefault(),
                Product_size = _context.Product_size.Where(p => p.Id == m.ProductSizeID).FirstOrDefault(),
                Pay_method = _context.Pay_method.FirstOrDefault(p=> p.Id == m.Pay_method_id),
            }).ToList();
            return View(orderr);
        }
    }
}
