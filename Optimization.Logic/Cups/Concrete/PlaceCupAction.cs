using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DbAccess.Cups;

namespace Optimization.Logic.Cups.Concrete
{
    public class PlaceCupAction : BskaActionStatus, IPlaceCupAction
    {
        private readonly IPlaceCupDbAccess _dbAccess;
        public PlaceCupAction(IPlaceCupDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public Cup BizAction(CupDto inputData)
        {
            if (inputData.Height<=0)
            {
                AddError("Height of cup is Invalied!!!");
            }

            if (inputData.Width <= 0)
            {
                AddError("Width of Cup is Invalied!!!");
            }

            var desStatus = Cup.CreateCup(inputData.Width, inputData.Height);

            CombineErrors(desStatus);

            if (!HasErrors)
            {
                _dbAccess.Add(desStatus.Result);
            }

            return HasErrors ? null : desStatus.Result;
        }
    }
}
