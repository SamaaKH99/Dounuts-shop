using Dounuts_shop.Models;
using Dounuts_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Dounuts_shop.Controllers
{
    public class DonutController : Controller
    {
        // Dependency Injection of the repositories.
        private readonly IDonutRepository _donutRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DonutController(IDonutRepository donutRepository, ICategoryRepository categoryRepository)
        {
            _donutRepository = donutRepository;
            _categoryRepository = categoryRepository;
        }

        // ViewResult is a built in return type in MVC to return a view.
        public ViewResult List()
        {
            // I will pass all data needed using view models
            DonutListViewModel donutListViewModel = new DonutListViewModel();
            donutListViewModel.donuts = _donutRepository.AllDonuts;

            donutListViewModel.CurrentCategory = "Chocolate";
            // Here I am asking the view to view all the donuts.
            return View(donutListViewModel);
        }

        // Viewbags are dynamic. They takes data to the view 
    }
}
