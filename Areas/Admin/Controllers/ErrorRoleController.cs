using Microsoft.AspNetCore.Mvc;

namespace Doan.Areas.Admin.Controllers
{
    public class ErrorRoleController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
