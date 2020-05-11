using HealthPromotion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository categotyRepositoty;

        public CategoryMenu(ICategoryRepository categotyRepositoty)
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
