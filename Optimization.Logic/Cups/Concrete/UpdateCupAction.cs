using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DbAccess.Cups;

namespace Optimization.Logic.Cups.Concrete
{
    public class UpdateCupAction : BskaActionStatus, IUpdateCupAction
    {
        private readonly IUpdateCupDbAccess _dbAccess;
        public UpdateCupAction(IUpdateCupDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public void BizAction(CupDto inputData)
        {
            var project = _dbAccess.GetCup(inputData.Id);
            if (project == null)
            {
                AddError("Could not find the cup.Someone entering illegal ids?");
                return;
            }

            var status = project.UpdateCup(inputData.Width, inputData.Height);

            CombineErrors(status);

            Message = $"cup is update: {project.ToString()}.";
        }
    }
}
