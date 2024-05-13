using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Doan.Areas.Admin.Models;
using Doan.Models;
using Doan.Utilities;


namespace Doan.Controllers
{
    [Route("~/register")]
    public class UserRegisterController : Controller
    {
        private readonly DataContext _context;
        public UserRegisterController(DataContext context)
        {
            _context = context;
        }
        public ActionResult Index()
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
            var check = _context.User.Where(m => m.Email == user.Email).FirstOrDefault();
            if (check != null)
            {
                Functions._MessageEmail = "Duplicate Email!";
                return RedirectToAction("Index", "Register");
            }
            Functions._MessageEmail = string.Empty;
            user.Password = Functions.MD5Password(user.Password);
            _context.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}
