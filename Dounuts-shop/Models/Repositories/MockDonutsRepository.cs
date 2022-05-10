using System.Collections.Generic;
using System.Linq;

namespace Dounuts_shop.Models
{
    public class MockDonutsRepository : IDonutRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Donut> AllDonuts =>
            new List<Donut>
            {
                new Donut {DonutId=1, Name="Chocolate Ice Glazed", ShortDescription="Donuts with chocolate", LongDescription="", Price=25.00, ImageURL="/images/chocolate-iced-glaze.png", ImageThumbnailURL="Chocolates", Instock=true, CategoryId=1},
                new Donut {DonutId=2, Name="Chocolate Ice Glazed", ShortDescription="", LongDescription="withwithwith", Price=25.00, ImageURL="/images/Glaze.png", ImageThumbnailURL="Chocolates", Instock=false, CategoryId=1},
                new Donut {DonutId=3, Name="Chocolate Ice Glazed", ShortDescription="", LongDescription="withwith", Price=25.00, ImageURL="/images/chocolate-iced-glaze.png", ImageThumbnailURL="Chocolates", Instock=true, CategoryId=1},
                new Donut {DonutId=4, Name="Chocolate Ice Glazed", ShortDescription="", LongDescription="withwith", Price=25.00, ImageURL="/images/chocolate-iced-glaze.png", ImageThumbnailURL="Chocolates", Instock=true, CategoryId=1},
                new Donut {DonutId=5, Name="Chocolate Ice Glazed", ShortDescription="", LongDescription="withwithwithwithwith", Price=25.00, ImageURL="/images/chocolate-iced-glaze.png", ImageThumbnailURL="Chocolates", Instock=false, CategoryId=1}
            };

        // Will be coded later
        public IEnumerable<Donut> DonutsOfTheWeek => throw new System.NotImplementedException();

        public Donut GetDonutById(int donutId)
        {
            return AllDonuts.FirstOrDefault(d => d.DonutId == donutId);
        }
    }
}
