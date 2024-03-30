using Microsoft.AspNetCore.Mvc;
using Doan.Models;

namespace Doan.Components
{
    [ViewComponent (Name ="Banner")]
    public class BannerComponents : ViewComponent
    {
        private readonly DataContext _context;
        public BannerComponents (DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var S = (from p in _context.Banner
                     select p).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", S));
        }
    }
}
