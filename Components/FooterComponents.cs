using Microsoft.AspNetCore.Mvc;
using Doan.Models;

namespace Doan.Components
{
	[ViewComponent (Name ="Footer")]
	public class FooterComponents : ViewComponent
	{
		private readonly DataContext _context;
		public FooterComponents(DataContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var mnList = (from m in _context.Footer
						  select m).ToList();
			return await Task.FromResult((IViewComponentResult)View ("Default", mnList));
		}
	}
}
