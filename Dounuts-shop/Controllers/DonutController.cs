using Dounuts_shop.Models;
using Dounuts_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        //public ViewResult List()
        //{
        //    // I will pass all data needed using view models
        //    DonutListViewModel donutListViewModel = new DonutListViewModel();
        //    donutListViewModel.donuts = _donutRepository.AllDonuts;

        //    donutListViewModel.CurrentCategory = "Chocolate";
        //    // Here I am asking the view to view all the donuts.
        //    return View(donutListViewModel);
        //}

        // Viewbags are dynamic. They takes data to the view 
        public ViewResult Details(int id)
        {
            var donut = _donutRepository.GetDonutById(id);
            if (donut == null)
            {
                return null;
            }
            return View(donut);
        }

        public ViewResult List(string category)
        {
            IEnumerable<Donut> donuts;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                donuts = _donutRepository.AllDonuts.OrderBy(p => p.DonutId);
                currentCategory = "All Donuts";
            }
            else
            {
                donuts = _donutRepository.AllDonuts.Where(p => p.Category.CategoryName == category).OrderBy(p => p.DonutId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new DonutListViewModel
            {
                donuts = donuts,
                CurrentCategory = currentCategory
            });
        }
    }
}
