using BskaGenericCoreLib;
using Optimization.Common.Models.Dto;
using Optimization.DataLayer.EfClasses.Equipment;

namespace Optimization.Logic.Cups
{
    public interface IPlaceCupAction : IGenericActionWriteDb<CupDto, Cup> { }
}
