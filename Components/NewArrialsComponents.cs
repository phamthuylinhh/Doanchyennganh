using Microsoft.AspNetCore.Mvc;
using Doan.Models;

namespace Doan.Components
{
    [ViewComponent (Name = "NewArrivals")]
    public class NewArrialsComponents : ViewComponent
    {
        private readonly DataContext _context;
        public NewArrialsComponents(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var S = (from p in _context.NewArrivals
					 select p).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", S));
        }
    }
}
