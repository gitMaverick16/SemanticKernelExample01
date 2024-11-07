using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SemanticKernelExample01.Context;

namespace SemanticKernelExample01.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string keyword)
        {
            var products = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                products = products.Where(p => EF.Functions.Like(p.Name, $"%{keyword}%") || EF.Functions.Like(p.Description, $"%{keyword}%"));
            }

            return View(await products.ToListAsync());
        }
    }
}
