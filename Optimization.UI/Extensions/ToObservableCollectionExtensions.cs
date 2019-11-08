﻿
namespace Optimization.UI.Extensions
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public static class ToObservableCollectionExtensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerable)
        {
            return new ObservableCollection<T>(enumerable);
        }
    }
}
