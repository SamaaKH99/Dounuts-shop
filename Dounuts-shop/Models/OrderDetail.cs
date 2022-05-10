using Dounuts_shop.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donuts_shop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DonutId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Donut Donut { get; set; }
        public virtual Order Order { get; set; }
    }

}
