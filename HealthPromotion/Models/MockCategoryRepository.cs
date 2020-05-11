using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId = 1, CategoryName = "Food"},
            new Category{CategoryId = 2, CategoryName = "Motivation"},
            new Category{CategoryId = 3, CategoryName = "Training"},
            new Category{CategoryId = 4, CategoryName = "Science"}
        };
    }
}
