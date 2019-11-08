using System;
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Cups.Concrete
{
    public class DeleteCupDbAccess : IDeleteCupDbAccess
    {
        private readonly OptimizationContext _context;

        public DeleteCupDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public void Delete(Cup cup)
        {
            _context.Cups.Remove(cup);
        }
    }
}
