using Dounuts_shop.Models;
using System.Collections.Generic;

namespace Donuts_shop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly AppDbContext _Context;

        public CategoryRepository(AppDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Category> AllCategories => _Context.Categories;
    }
}