using Microsoft.AspNetCore.Mvc;
using Doan.Models;
namespace Doan.Components
{
    [ViewComponent (Name ="Products")]
    public class ProductsComponents : ViewComponent
    {
        private readonly DataContext _context;
        public ProductsComponents (DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync ()
        {
            var products = (from p in _context.Products
                            select p).ToList ();
            return await Task.FromResult((IViewComponentResult)View("Default", products));
        }
    }
}
