using Dounuts_shop.Models;

namespace Donuts_shop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Donut Donut { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
