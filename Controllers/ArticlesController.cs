using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace E_commerce.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext context;

        public ArticlesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/articles", Name = "articles")]
        public IActionResult Index()
        {
            var articles = context.Articles.ToList();

            return View(articles);
        }

        // GET /articles/black-tshirt
        [Route("/articles/{urlSlug}", Name = "articledetails")]
        public ActionResult Details(string urlSlug)
        {
            var article = context.Articles.FirstOrDefault(article => article.UrlSlug == urlSlug);

            // .\Views\Articles\Details.cshtml
            return View(article);
        }
    }
}
