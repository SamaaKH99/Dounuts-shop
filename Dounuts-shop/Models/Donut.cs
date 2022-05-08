namespace Dounuts_shop.Models
{
    public class Donut
    {
        public int DonutId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumbnailURL { get; set; }
        public bool IsDonutOfTheWeek { get; set; }
        public bool Instock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
