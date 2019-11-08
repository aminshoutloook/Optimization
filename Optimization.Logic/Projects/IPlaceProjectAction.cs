
using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DataLayer.EfClasses.Projects;

namespace Optimization.Logic.Projects
{
    public interface IPlaceProjectAction : IGenericActionWriteDb<ProjectDto, Project> { }
}
