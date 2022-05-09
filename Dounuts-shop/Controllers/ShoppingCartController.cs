using Donuts_shop.Models;
using Donuts_shop.ViewModels;
using Dounuts_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Donuts_shop.Controllers
{
    public class ShoppingCartController : Controller
    {
        public readonly IDonutRepository _donutRepository;
        public readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDonutRepository donutRepository, ShoppingCart shoppingCart)
        {
            _donutRepository = donutRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = (decimal)_shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var selectedDonut = _donutRepository.AllDonuts.FirstOrDefault(donut => donut.DonutId == id);

            if (selectedDonut != null)
            {
                _shoppingCart.AddToCart(selectedDonut, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int donutId)
        {
            var selectedDonut = _donutRepository.AllDonuts.FirstOrDefault(p => p.DonutId == donutId);

            if (selectedDonut != null)
            {
                _shoppingCart.RemoveFromCart(selectedDonut);
            }
            return RedirectToAction("Index");
        }
    }

}
