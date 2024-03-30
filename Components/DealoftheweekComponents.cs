
using Microsoft.AspNetCore.Mvc;
using Doan.Models;

namespace Doan.Components
{
	[ViewComponent(Name = "Dealoftheweek")]
	public class DealoftheweekComponents : ViewComponent
	{
		private readonly DataContext _context;
		public DealoftheweekComponents (DataContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var S = (from p in _context.Dealoftheweek
					 select p).ToList();
			return await Task.FromResult((IViewComponentResult)View("Default", S));
		}
	}
}
