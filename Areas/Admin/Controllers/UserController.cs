﻿using Doan.Models;
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
            var mnList = _context.User.OrderBy(m => m.Id).ToList();
            return View(mnList);
        }
    }
}
