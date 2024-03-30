using Doan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doan.Components
{
	[ViewComponent(Name = "NewArrivals")]
	public class NewArrivalsComponents : ViewComponent
	{
		private readonly DataContext _context;
		public NewArrivalsComponents (DataContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var List =(from p in _context.NewArrivals
					   select p).ToList();
			return await Task.FromResult((IViewComponentResult)View("Default", List));
		}
	}
}
