using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DataLayer.EfClasses.Projects;
using Optimization.DbAccess.Projects;

namespace Optimization.Logic.Projects.Concrete
{
    public class PlaceProjectAction : BskaActionStatus, IPlaceProjectAction
    {
        private readonly IPlaceProjectDbAccess _dbAccess;
        public PlaceProjectAction(IPlaceProjectDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public Project BizAction(ProjectDto inputData)
        {
            if (string.IsNullOrWhiteSpace(inputData.Name))
            {
                AddError("Project Name is required...");
            }

            var desStatus = Project.CreateProject(inputData.Name,inputData.Description);

            CombineErrors(desStatus);

            if (!HasErrors)
            {
                _dbAccess.Add(desStatus.Result);
            }

            return HasErrors ? null : desStatus.Result;
        }
    }
}
