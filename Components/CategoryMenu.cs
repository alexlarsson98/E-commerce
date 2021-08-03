using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ApplicationDbContext context;

        public CategoryMenu(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = context.Categories.ToList();

            return View(categories);
        }
    }
}
