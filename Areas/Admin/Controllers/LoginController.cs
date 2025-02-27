﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Doan.Areas.Admin.Models;
using Doan.Models;
using Doan.Utilities;

namespace Doan.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("~/admin/login")]
    public class LoginController : Controller
    {
        private readonly DataContext _context;
        public LoginController (DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index (AdminUser user)
        {
            if (user == null)
            {
                return NotFound();
            }
            string pw = Functions.MD5Password(user.Password);
            var check = _context.AdminUsers.Where(m=>(m.Email == user.Email) && (m.Password == pw)).FirstOrDefault();
            if (check == null)
            {
                Functions._Message = "Invalid UserName or Password!";
                return RedirectToAction("Index", "Login");
            }
            Functions._Message = string.Empty;
            Functions._UserID = check.UserId;
            Functions._UserName = string.IsNullOrEmpty(check.UserName) ? string.Empty : check.UserName;
            Functions._Email = string.IsNullOrEmpty(check.Email) ? string.Empty : check.Email;
            Functions._Role = (int)check.Role;
            return RedirectToAction("Index", "Home");
        }

    }
}
