
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Pieces.Concrete
{
    public class UpdatePieceDbAccess : IUpdatePieceDbAccess
    {
        private readonly OptimizationContext _context;

        public UpdatePieceDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public Piece GetPiece(long pieceId)
        {
            return _context.Find<Piece>(pieceId);
        }
    }
}
