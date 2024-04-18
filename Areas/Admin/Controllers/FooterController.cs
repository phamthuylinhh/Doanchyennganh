using Doan.Models;
using Doan.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Doan.Areas.Admin.Controllers
{

	[Area("Admin")]
	public class FooterController : Controller
	{
		private readonly DataContext _context;
		public FooterController(DataContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			if (!Functions.IsLogin())
				return RedirectToAction("Index", "Login");
			var mnList = _context.Footer.OrderBy(m => m.Id).ToList();
			return View(mnList);
		}
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var mn = _context.Footer.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            return View(mn);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deleMenu = _context.Footer.Find(id);
            if (deleMenu == null)
            {
                return NotFound();
            }
            _context.Footer.Remove(deleMenu);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            var mnList = (from m in _context.Footer
                          select new SelectListItem()
                          {
                              Text = m.Title,
                              Value = m.Id.ToString(),
                          }).ToList();
            //mnList.Insert(0, new SelectListItem()
            //{
            //    Text = "---Select---",
            //    Value = "0"
            //});
            ViewBag.mnList = mnList;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Footer mn)
        {
            if (ModelState.IsValid)
            {
                _context.Footer.Add(mn);
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
            var mn = _context.Footer.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            var mnList = (from m in _context.Footer
                          select new SelectListItem()
                          {
                              Text = m.Title,
                              Value = m.Id.ToString(),
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
        public IActionResult Edit(Footer mn)
        {
            if (ModelState.IsValid)
            {
                _context.Footer.Update(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }
    }
}
