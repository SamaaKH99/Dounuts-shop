using Dounuts_shop.Models;
using System.Collections.Generic;

namespace Dounuts_shop.ViewModels
{
    public class DonutListViewModel
    {
        public IEnumerable<Donut> donuts { get; set; }
        public string CurrentCategory { get; set; }
    }
}
