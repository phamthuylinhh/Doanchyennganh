using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Doan.Models;

using Doan.Utilities;

namespace Doan.Controllers
{
    [Route("~/login")]
    public class LoginController : Controller
    {
        private readonly DataContext _context;
        public LoginController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            if (user == null)
            {
                return NotFound();
            }
            string pw = Functions.MD5Password(user.Password);
            var check = _context.User.Where(m => (m.Email == user.Email) && (m.Password == pw)).FirstOrDefault();
            if (check == null)
            {
                Functions._Message = "Invalid UserName or Password!";
                return RedirectToAction("Index", "Login");
            }
            Functions._Message = string.Empty;
            Functions._UserID = check.Id;
            Functions._UserName = string.IsNullOrEmpty(check.Name) ? string.Empty : check.Name;
            Functions._Email = string.IsNullOrEmpty(check.Email) ? string.Empty : check.Email;
            return RedirectToAction("Index", "Home");
        }

    }
}
