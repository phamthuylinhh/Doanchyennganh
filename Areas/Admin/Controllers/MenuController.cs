﻿using Microsoft.AspNetCore.Mvc;
using Doan.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Doan.Utilities;

namespace Doan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly DataContext _context;
        public MenuController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            var mnList = _context.Menu.OrderBy(m=>m.MenuID).ToList();
            return View(mnList);    
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var mn = _context.Menu.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            return View(mn);
        }
        [HttpPost]
        public  IActionResult Delete (int id)
        {
            var deleMenu = _context.Menu.Find(id);
            if (deleMenu == null)
            {
                return NotFound();  
            }
            _context.Menu.Remove(deleMenu);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            var mnList = (from m in _context.Menu
                          select new SelectListItem()
                          {
                              Text = m.MenuName,
                              Value = m.MenuID.ToString(),
                          }).ToList();
            mnList.Insert(0, new SelectListItem()
            {
                Text = "---Select---",
                Value = "0"
            });
            ViewBag.mnList = mnList;
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (Menu mn)
        {
            if(ModelState.IsValid)
            {
                _context.Menu.Add(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var mn =_context.Menu.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            var mnList = (from m in _context.Menu
                          select new SelectListItem()
                          {
                              Text = m.MenuName,
                              Value = m.MenuID.ToString(),
                          }).ToList();
            mnList.Insert(0, new SelectListItem()
            {
                Text = "---Select----",
                Value = string.Empty
            });
            ViewBag.mnList = mnList;
            return View(mn);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (Menu mn)
        {
            if (ModelState.IsValid)
            {
                _context.Menu.Update(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }
    }
}
