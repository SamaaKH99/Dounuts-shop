using Dounuts_shop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Donuts_shop.Models
{
    public class DonutRepository : IDonutRepository
    {
        // Easy accsess to the AppDbContext because of the dependency injection.
        private readonly AppDbContext _context;

        public DonutRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Donut> AllDonuts
        {
            get { return _context.Donuts.Include(c => c.Category); }
        }
        public IEnumerable<Donut> DonutsOfTheWeek
        {
            get { return _context.Donuts.Include(c => c.Category).Where(d => d.IsDonutOfTheWeek); }
        }

        public Donut GetDonutById(int donutId)
        {
            return _context.Donuts.FirstOrDefault(d => d.DonutId == donutId);
        }
    }
}
