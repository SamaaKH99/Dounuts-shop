using System.Collections.Generic;

namespace Dounuts_shop.Models
{
    public interface IDonutRepository
    {
        IEnumerable<Donut> AllDonuts { get; }
        IEnumerable<Donut> DonutsOfTheWeek { get; }
        Donut GetDonutById(int donutId);
    }
}
