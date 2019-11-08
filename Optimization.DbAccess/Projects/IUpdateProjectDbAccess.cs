
using Optimization.DataLayer.EfClasses.Projects;
using System;

namespace Optimization.DbAccess.Projects
{
    public interface IUpdateProjectDbAccess
    {
        Project GetProject(Guid projectId);
        bool HaveAnyDependency(Guid projectId);
    }
}
