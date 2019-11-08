using System;
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Cups.Concrete
{
    public class PlaceCupDbAccess : IPlaceCupDbAccess
    {
        private readonly OptimizationContext _context;

        public PlaceCupDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public void Add(Cup cup)
        {
            _context.Cups.Add(cup);
        }
    }
}
