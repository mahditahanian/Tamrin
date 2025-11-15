using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin.T2.Extention
{
    public static class QueryableExtensions
    {
       public static IEnumerable<T> WhereIf<T>(
            this IEnumerable<T> source,
            bool condition,
            Func<T, bool> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }
    }
}
