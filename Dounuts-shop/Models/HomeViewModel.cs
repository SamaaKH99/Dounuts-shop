using Dounuts_shop.Models;
using System.Collections;
using System.Collections.Generic;

namespace Donuts_shop.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Donut> DonutsOfTheWeek { get; set; }
    }
}
