using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DbAccess.Pieces;
using System;


namespace Optimization.Logic.Pieces.Concrete
{
    public class UpdatePieceAction : BskaActionStatus, IUpdatePieceAction
    {
        private readonly IUpdatePieceDbAccess _dbAccess;
        public UpdatePieceAction(IUpdatePieceDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public void BizAction(PieceDto inputData)
        {
            var project = _dbAccess.GetPiece(inputData.Id);
            if (project == null)
            {
                AddError("Could not find the Piece.Someone entering illegal ids?");
                return;
            }

            var status = project.UpdatePiece(inputData.Width, inputData.Height);

            CombineErrors(status);

            Message = $"Piece is update: {project.ToString()}.";
        }
    }
}
