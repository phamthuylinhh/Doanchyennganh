using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Doan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly DataContext _context;
        public OrderController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            var mnList = _context.Order.OrderBy(m => m.Id).ToList();
            return View(mnList);
        }
        public IActionResult Cancel(string id, int productId, int productSizeId)
        {
            var order = _context.Order.Find(id, productId, productSizeId);
            if (order == null)
            {
                return NotFound();
            }    
            if (order.Oder_status == "Đã xác nhận")
            {
                return BadRequest("Cannot cancel a confirmed order.");
            }
            order.Oder_status = "Đã huỷ";
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Confirm (string id, int productId, int productSizeId)
        {
            var order = _context.Order.Find(id, productId, productSizeId);
            if (order == null)
            {
                return NotFound();
            }
            order.Oder_status = "Đã xác nhận";
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
