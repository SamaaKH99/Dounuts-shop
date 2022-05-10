using System;

namespace Donuts_shop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.orders.Add(order);
            _appDbContext.SaveChanges();


            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    DonutId = shoppingCartItem.Donut.DonutId,
                    OrderId = order.OrderId,
                    Price = (decimal)shoppingCartItem.Donut.Price
                };

                _appDbContext.orderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();

        }
    }

}
