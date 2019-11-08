using BskaGenericCoreLib;
using Optimization.DbAccess.Cups;

namespace Optimization.Logic.Cups.Concrete
{
    public class DeleteCupAction : BskaActionStatus, IDeleteCupAction
    {
        private readonly IDeleteCupDbAccess _dbAccess;
        private readonly IUpdateCupDbAccess _updateDbAccess;
        public DeleteCupAction(IDeleteCupDbAccess dbAccess
            , IUpdateCupDbAccess updateDbAccess)
        {
            _dbAccess = dbAccess;
            _updateDbAccess = updateDbAccess;
        }

        public void BizAction(int inputData)
        {
            var item = _updateDbAccess.GetCup(inputData);
            if (item == null)
            {
                AddError("Could not find the cup.Someone entering illegal ids?");
            }
            if (!HasErrors)
            {
                _dbAccess.Delete(item);
                Message = $"Cup is Delete: {item.ToString()}.";
            }
        }
    }
}
