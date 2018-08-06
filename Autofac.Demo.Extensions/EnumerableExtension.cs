using System;
using System.Collections.Generic;
using System.Linq;

namespace Autofac.Demo.Extensions
{
    public static class EnumerableExtension
    {
        public static IEnumerable<T> WhereCriteria<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            return enumerable.Where(item => predicate != null && predicate(item));
        }
    }
}
