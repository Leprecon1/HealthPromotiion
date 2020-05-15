using HealthPromotion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Components
{
    public class CategoryMenuSidebar : ViewComponent
    {
        private readonly ICategoryRepository categotyRepositoty;

        public CategoryMenuSidebar(ICategoryRepository categotyRepositoty)
        {
            this.categotyRepositoty = categotyRepositoty;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categotyRepositoty.AllCategories.OrderBy(c => c.CategoryId);
            return View(categories);
        }
    }
}
