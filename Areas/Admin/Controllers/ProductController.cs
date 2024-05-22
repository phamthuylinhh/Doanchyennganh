using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.StaticFiles;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Doan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly DataContext _context;
       
        public ProductController(DataContext context)
        {
            _context = context;
         
        }
        public IActionResult UploadImage(int id)
        {
            // Truyền id của sản phẩm đến view để biết đây là upload ảnh cho sản phẩm nào
            ViewBag.ProductId = id;
            return View();
        }

        
        public IActionResult Index()
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            var mnList = _context.Products.OrderBy(m => m.Id).ToList();
            return View(mnList);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var mn = _context.Products.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            return View(mn);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var sq= _context.Products.Find(id);
            if (sq == null)
            {
                return NotFound();
            }
            _context.Products.Remove(sq);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UploadImages (int id, IFormFile image)
        //{
        //    var product = await _context.Products.FindAsync(id);
        //    if(product == null)
        //    {
        //        return NotFound();
        //    }
        //    if (image != null && image.Length >0)
        //    {
        //        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
        //        string uniqueFileName = Guid.NewGuid().ToString()+"_" +image.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await image.CopyToAsync(fileStream);
        //        }
        //        product.Images = uniqueFileName;
        //        await _context.SaveChangesAsync();

        //    }
        //    return RedirectToAction("Index");
        //}
        public IActionResult Create()
        {
            var pdList = (from m in _context.Products
                          select new SelectListItem()
                          {
                              Text = m.Category_id.ToString(),
                              Value = m.Id.ToString(),
                          }).ToList();
            pdList.Insert(0, new SelectListItem()
            {
                Text = "---Select---",
                Value = "0"
            });
            ViewBag.pdList = pdList;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Products mn)
        {
            if (ModelState.IsValid)
            {
                //if(image !=null && image.Length>0)
                //{
                //    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                //    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                //    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                //    using (var fileStream = new FileStream(filePath, FileMode.Create))
                //    {
                //        image.CopyTo(fileStream);
                //    }
                //    mn.Images = uniqueFileName;
                //}
                _context.Products.Add(mn);
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
            var mn = _context.Products.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            var mnList = (from m in _context.Products
                          select new SelectListItem()
                          {
                              Text = m.Category_id.ToString(),
                              Value = m.Id.ToString(),
                          }).ToList();
            mnList.Insert(0, new SelectListItem()
            {
                Text = "---Select----",
                Value = "0"
            });
            ViewBag.mnList = mnList;
            return View(mn);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Products mn)
        {
            if (ModelState.IsValid)
            {
                //if (image != null && image.Length > 0)
                //{
                //    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                //    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                //    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                //    using (var fileStream = new FileStream(filePath, FileMode.Create))
                //    {
                //        image.CopyTo(fileStream);
                //    }
                //    mn.Images = uniqueFileName;
                //}
                _context.Products.Update(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }

        
    }
}
