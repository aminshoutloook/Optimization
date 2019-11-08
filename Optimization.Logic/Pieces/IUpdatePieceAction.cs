using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;

namespace Optimization.Logic.Pieces
{
    public interface IUpdatePieceAction : IGenericActionInOnlyWriteDb<PieceDto>
    {
    }
}
