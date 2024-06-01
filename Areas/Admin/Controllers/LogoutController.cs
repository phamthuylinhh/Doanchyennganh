using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Doan.Areas.Admin.Controllers
{
    public class LogoutController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            Functions._UserID = 0;
            Functions._UserName = string.Empty;
            Functions._Email = string.Empty;
            Functions._Message = string.Empty;
            Functions._MessageEmail = string.Empty;


            return RedirectToAction("Index", "home", new { area = "" }); 

        }
    }
}
