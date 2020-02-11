using System;
using System.Collections.Generic;
using System.Linq;

namespace DoIf
{
    public static partial class Fun
    {
        // todo Cover all LINQ

        public static IEnumerable<TSource> AppendIf<TSource>(this IEnumerable<TSource> source,
            bool condition,
            TSource element)
            => source.DoIf(condition, s => s.Append(element));

        public static IEnumerable<TSource> ConcatIf<TSource>(this IEnumerable<TSource> first,
            bool condition,
            IEnumerable<TSource> second)
            => first.DoIf(condition, s => s.Concat(second));

        public static IEnumerable<TSource> PrependIf<TSource>(this IEnumerable<TSource> source,
            bool condition,
            TSource element)
            => source.DoIf(condition, s => s.Prepend(element));

        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source,
            bool condition,
            Func<TSource, bool> predicate)
            => source.DoIf(condition, s => s.Where(predicate));


        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source,
            string condition,
            Func<TSource, bool> predicate)
            => source.DoIf(condition.IsNotEmpty(), s => s.Where(predicate));
    }
}