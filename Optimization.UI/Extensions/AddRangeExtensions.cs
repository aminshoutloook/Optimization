
using System.Collections.Generic;

namespace Optimization.UI.Extensions
{
    public static class AddRangeExtensions
    {
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                collection.Add(item);
            }
        }
    }
}
