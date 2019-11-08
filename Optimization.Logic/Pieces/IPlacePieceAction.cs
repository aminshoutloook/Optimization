using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DataLayer.EfClasses.Equipment;

namespace Optimization.Logic.Pieces
{
    public interface IPlacePieceAction : IGenericActionWriteDb<PieceDto, Piece> { }
}
