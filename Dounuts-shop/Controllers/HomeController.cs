using Dounuts_shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Donuts_shop.Models;

namespace Dounuts_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDonutRepository _donutRepository;

        public HomeController(IDonutRepository donutRepository)
        {
            _donutRepository = donutRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                DonutsOfTheWeek = _donutRepository.DonutsOfTheWeek
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
