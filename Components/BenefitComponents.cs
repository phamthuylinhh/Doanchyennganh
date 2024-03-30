using Microsoft.AspNetCore.Mvc;
using Doan.Models;
namespace Doan.Components
{
    [ViewComponent(Name = "Benefit")]
    public class BenefitComponents : ViewComponent
    {
        private readonly DataContext _context;
        public BenefitComponents(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
          var mnList = (from m in _context.Benefit
                        select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", mnList));
        }


    }
}
