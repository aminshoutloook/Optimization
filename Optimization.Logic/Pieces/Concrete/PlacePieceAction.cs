
using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DbAccess.Pieces;

namespace Optimization.Logic.Pieces.Concrete
{
    public class PlacePieceAction: BskaActionStatus, IPlacePieceAction
    {
        private readonly IPlacePieceDbAccess _dbAccess;
        public PlacePieceAction(IPlacePieceDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public Piece BizAction(PieceDto inputData)
        {
            if (inputData.Height <= 0)
            {
                AddError("Height of Piece is Invalied!!!");
            }

            if (inputData.Width <= 0)
            {
                AddError("Width of Piece is Invalied!!!");
            }

            var desStatus = Piece.CreatePiece(inputData.Width, inputData.Height);

            CombineErrors(desStatus);

            if (!HasErrors)
            {
                _dbAccess.Add(desStatus.Result);
            }

            return HasErrors ? null : desStatus.Result;
        }
    }
}
