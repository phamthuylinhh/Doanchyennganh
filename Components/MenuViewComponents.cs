using Microsoft.AspNetCore.Mvc;
using Doan.Models;

namespace Doan.Component
{
    [ViewComponent(Name = "MenuView")]
    public class MenuViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public MenuViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMenu = (from m in _context.Menu
                              where m.IsActive == true && m.Position == 1
                              select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofMenu));


        }

    }
}
