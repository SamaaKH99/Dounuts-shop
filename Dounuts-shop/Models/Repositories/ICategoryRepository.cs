using System.Collections.Generic;

namespace Dounuts_shop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
