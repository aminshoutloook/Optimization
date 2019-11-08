using System;
using BskaGenericCoreLib;
using Optimization.DbAccess.Projects;

namespace Optimization.Logic.Projects.Concrete
{
    public class DeleteProjectAction : BskaActionStatus, IDeleteProjectAction
    {
        private readonly IDeleteProjectDbAccess _dbAccess;
        private readonly IUpdateProjectDbAccess _updateDbAccess;
        public DeleteProjectAction(IDeleteProjectDbAccess dbAccess
            , IUpdateProjectDbAccess updateDbAccess)
        {
            _dbAccess = dbAccess;
            _updateDbAccess = updateDbAccess;
        }

        public void BizAction(Guid inputData)
        {
            var item = _updateDbAccess.GetProject(inputData);
            if (item == null)
            {
                AddError("Could not find the project. Someone entering illegal ids?");
            }

            if (_updateDbAccess.HaveAnyDependency(inputData))
            {
                AddError("Could not to delete project.");
            }

            if (!HasErrors)
            {
                _dbAccess.Delete(item);
                Message = $"project is Delete: {item.ToString()}.";
            }
        }
    }
}
