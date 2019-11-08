using System;
using System.Linq;
using Optimization.DataLayer.EfClasses.Projects;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Projects.Concrete
{
    public class UpdateProjectDbAccess : IUpdateProjectDbAccess
    {
        private readonly OptimizationContext _context;

        public UpdateProjectDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public Project GetProject(Guid projectId)
        {
            return _context.Find<Project>(projectId);
        }

        public bool HaveAnyDependency(Guid projectId)
        {
            return _context.Projects.Where(s => s.Id == projectId).Any(s => s.Cups.Any()
            || s.Pieces.Any());
        }
    }
}
