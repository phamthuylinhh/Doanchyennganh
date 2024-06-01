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
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                const int adminRoleId = 2; 
                if (Functions._Role != adminRoleId)
                {

                    return RedirectToAction("Index", "ErrorRole");
                }
            }
            var mnList = _context.Order.OrderBy(m => m.Id).ToList();
            return View(mnList);
        }
        public IActionResult Cancel(string id, int productId, int productSizeId)
        {
            if (!Functions.IsLogin())
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                const int adminRoleId = 2;
                if (Functions._Role != adminRoleId)
                {

                    return RedirectToAction("Index", "ErrorRole");
                }
            }
            var order = _context.Order.Find(id, productId, productSizeId);

            if (order == null)
            {
                return NotFound();
            }    
          
            order.Oder_status = "Đã huỷ";
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Confirm (string id, int productId, int productSizeId)
        {
            if (!Functions.IsLogin())
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                const int adminRoleId = 2;
                if (Functions._Role != adminRoleId)
                {

                    return RedirectToAction("Index", "ErrorRole");
                }
            }
            var order = _context.Order.Find(id, productId, productSizeId);
            if (order == null)
            {
                return NotFound();
            }
            order.Oder_status = "Đã xác nhận";
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Complete (string id , int productId, int productSizeId)
        {
            if (!Functions.IsLogin())
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                const int adminRoleId = 2;
                if (Functions._Role != adminRoleId)
                {

                    return RedirectToAction("Index", "ErrorRole");
                }
            }
            var order = _context.Order.Find(id, productId, productSizeId);
            if(order == null)
            {
                return NotFound();
            }
            order.Oder_status = "Hoàn thành";
            _context.SaveChanges();
            return RedirectToAction(nameof(Index)); 
        }
    }
}
