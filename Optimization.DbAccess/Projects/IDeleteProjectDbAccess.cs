using Optimization.DataLayer.EfClasses.Projects;

namespace Optimization.DbAccess.Projects
{
    public interface IDeleteProjectDbAccess
    {
        void Delete(Project project);
    }
}
