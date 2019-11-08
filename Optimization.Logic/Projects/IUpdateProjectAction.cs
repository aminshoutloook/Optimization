using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;

namespace Optimization.Logic.Projects
{
    public interface IUpdateProjectAction : IGenericActionInOnlyWriteDb<ProjectDto>
    {
    }
}
