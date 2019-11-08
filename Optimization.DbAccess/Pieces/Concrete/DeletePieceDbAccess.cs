
using Optimization.DataLayer.EfClasses.Equipment;
using Optimization.DataLayer.EfCode;

namespace Optimization.DbAccess.Pieces.Concrete
{
    public class DeletePieceDbAccess : IDeletePieceDbAccess
    {
        private readonly OptimizationContext _context;

        public DeletePieceDbAccess(OptimizationContext context)
        {
            _context = context;
        }

        public void Delete(Piece piece)
        {
            _context.Pieces.Remove(piece);
        }
    }
}
