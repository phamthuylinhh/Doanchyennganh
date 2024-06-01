using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Doan.Controllers
{
    public class UserLogoutController : Controller
    {
        [Route("~/Logout")]
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
