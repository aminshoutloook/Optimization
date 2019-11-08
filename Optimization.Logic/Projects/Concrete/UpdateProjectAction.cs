using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DbAccess.Projects;

namespace Optimization.Logic.Projects.Concrete
{
    public class UpdateProjectAction : BskaActionStatus, IUpdateProjectAction
    {
        private readonly IUpdateProjectDbAccess _dbAccess;
        public UpdateProjectAction(IUpdateProjectDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public void BizAction(ProjectDto inputData)
        {
            var project = _dbAccess.GetProject(inputData.Id);
            if (project == null)
            {
                AddError("Could not find the project. Someone entering illegal ids?");
                return;
            }

            var status = project.UpdateProject(inputData.Name,inputData.Description);

            CombineErrors(status);

            Message = $"project is update: {project.ToString()}.";
        }
    }
}
