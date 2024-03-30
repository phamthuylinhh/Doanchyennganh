using Doan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doan.Controllers
{
	public class ProductController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataContext _context;

		public ProductController(ILogger<HomeController> logger, DataContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
