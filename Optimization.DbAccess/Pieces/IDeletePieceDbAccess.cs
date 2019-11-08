
using Optimization.DataLayer.EfClasses.Equipment;

namespace Optimization.DbAccess.Pieces
{
    public interface IDeletePieceDbAccess
    {
        void Delete(Piece piece);
    }
}
