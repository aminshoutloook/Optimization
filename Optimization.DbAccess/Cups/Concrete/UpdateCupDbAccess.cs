using System;
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Cups.Concrete
{
    public class UpdateCupDbAccess : IUpdateCupDbAccess
    {
        private readonly OptimizationContext _context;

        public UpdateCupDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public Cup GetCup(int cupId)
        {
            return _context.Cups.Find(cupId);
        }
    }
}
