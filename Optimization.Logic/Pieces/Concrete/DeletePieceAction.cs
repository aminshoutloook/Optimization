using BskaGenericCoreLib;
using Optimization.DbAccess.Pieces;

namespace Optimization.Logic.Pieces.Concrete
{
    public class DeletePieceAction : BskaActionStatus, IDeletePieceAction
    {
        private readonly IDeletePieceDbAccess _dbAccess;
        private readonly IUpdatePieceDbAccess _updateDbAccess;
        public DeletePieceAction(IDeletePieceDbAccess dbAccess
            , IUpdatePieceDbAccess updateDbAccess)
        {
            _dbAccess = dbAccess;
            _updateDbAccess = updateDbAccess;
        }

        public void BizAction(int inputData)
        {
            var item = _updateDbAccess.GetPiece(inputData);
            if (item == null)
            {
                AddError("Could not find the Piece.Someone entering illegal ids?");
            }
            if (!HasErrors)
            {
                _dbAccess.Delete(item);
                Message = $"Piece is Delete: {item.ToString()}.";
            }
        }
    }
}
