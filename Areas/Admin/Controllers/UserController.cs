using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Doan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly DataContext _context;
        public UserController(DataContext context) { _context = context; }
        public IActionResult Index()
        {
            //if (!Functions.IsLogin()) return RedirectToAction("index", "home", new { area = "" });
            //var users = _context.AdminUsers.Select(u => new
            //{
            //    id = u.UserId,
            //    login_name = u.UserName,
            //    email = u.Email,
            //    password = u.Password,

            //    status = u.IsActive,

            //}).ToList();
            ////ViewData["actionName"] = "index";
            ////ViewData["controllerName"] = "user";

            //var dropdown = new List<SelectListItem> {
            //    new SelectListItem()
            //    {
            //        Text = "Tên người dùng",
            //        Value = "1",
            //    },new SelectListItem()
            //    {
            //        Text = "Id người dùng",
            //        Value = "2",
            //    },new SelectListItem()
            //    {
            //        Text = "Email",
            //        Value = "3",
            //    }
            //};

            //ViewBag.SearchView = new
            //{
            //    form = "#tbody",
            //    dropdown = dropdown,
            //}; if (!Functions.IsLogin())
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            var mnList = _context.AdminUsers.OrderBy(m => m.UserId).ToList();
            return View(mnList);
        }
    }
}
