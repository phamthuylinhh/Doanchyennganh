using Microsoft.AspNetCore.Mvc;
using Doan.Models;

namespace Doan.Components
{
	[ViewComponent(Name = "Slide")]
	public class SlideComponents : ViewComponent
	{
		private readonly DataContext _context;
		public SlideComponents(DataContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var listofSlide = (from p in _context.Slide
							   where p.IsActive == true
							   select p).ToList();
			return await Task.FromResult((IViewComponentResult)View("Default", listofSlide));


		}
	}
}
