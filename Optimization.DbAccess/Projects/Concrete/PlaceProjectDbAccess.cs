
using Optimization.DataLayer.EfClasses.Projects;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Projects.Concrete
{
    public class PlaceProjectDbAccess : IPlaceProjectDbAccess
    {
        private readonly OptimizationContext _context;

        public PlaceProjectDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public void Add(Project project)
        {
            _context.Projects.Add(project);
        }
    }
}
