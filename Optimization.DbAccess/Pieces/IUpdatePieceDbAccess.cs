using Optimization.DataLayer.EfClasses.Equipment;

namespace Optimization.DbAccess.Pieces
{
    public interface IUpdatePieceDbAccess
    {
        Piece GetPiece(long pieceId);
    }
}
