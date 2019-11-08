using Optimization.DataLayer.EfClasses.Projects;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Projects.Concrete
{
    public class DeleteProjectDbAccess : IDeleteProjectDbAccess
    {
        private readonly OptimizationContext _context;

        public DeleteProjectDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public void Delete(Project projec)
        {
            _context.Projects.Remove(projec);
        }
    }
}
