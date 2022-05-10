using System.Collections.Generic;

namespace Dounuts_shop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Chocolate", Description = "lorem ipsum"},
                new Category { CategoryId = 2, CategoryName = "Glaze", Description = "lorem ipsum"},
                new Category { CategoryId=3, CategoryName = "Seasonal", Description = "lorem ipsum" }
            };
    }
}
