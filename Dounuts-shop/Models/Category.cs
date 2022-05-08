using System.Collections.Generic;

namespace Dounuts_shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        // Relation 1 Category to many Donuts so --> Adding list at the category class.
        public List<Donut> Donuts { get; set; }
    }
}
