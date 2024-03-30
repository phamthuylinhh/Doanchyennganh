using Microsoft.AspNetCore.Mvc;
using Doan.Models;

namespace Doan.Areas.Admin.Components
{

	[ViewComponent (Name ="AdminMenu")]
	public class AdminMenuComponent : ViewComponent
	{
		private readonly DataContext _context;
		public AdminMenuComponent(DataContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var mnlist = (from m in _context.AdminMenu
						  where (m.isActive == true)
						  select m).ToList();
			return await Task.FromResult((IViewComponentResult)View("Default", mnlist));
		}
	}
}
