
using Optimization.DataLayer.EfClasses.Equipment;

namespace Optimization.DbAccess.Cups
{
    public interface IUpdateCupDbAccess
    {
        Cup GetCup(int cupId);
    }
}
