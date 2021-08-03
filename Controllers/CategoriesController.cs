using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/categories", Name = "categories")]
        public IActionResult Index()
        {
            var categories = context.Categories.ToList(); 

            return View(categories);
        }

        // GET /ProductCategories/Details/shirts
        [Route("/categories/{urlSlug}", Name = "category")]
        public async Task<IActionResult> Details(string urlSlug)
        {
            var category = await context.Categories
                .Include(x => x.Articles)
                .FirstOrDefaultAsync(m => m.UrlSlug == urlSlug);

            return View(category);
        }
    }
}
