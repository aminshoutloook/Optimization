
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Pieces.Concrete
{
    public class PlacePieceDbAccess : IPlacePieceDbAccess
    {
        private readonly OptimizationContext _context;

        public PlacePieceDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public void Add(Piece piece)
        {
            _context.Pieces.Add(piece);
        }
    }
}
