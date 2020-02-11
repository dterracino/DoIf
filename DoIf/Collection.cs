using System.Collections.Generic;

namespace DoIf
{
    public static partial class Fun
    {
        public static ICollection<TSource> AddIf<TSource>(this ICollection<TSource> source, bool condition,
            TSource item)
            => source.DoIf(condition, s => s.Add(item));

        public static ICollection<TSource> ClearIf<TSource>(this ICollection<TSource> source, bool condition)
            => source.DoIf(condition, s => s.Clear());

        public static ICollection<TSource> RemoveIf<TSource>(this ICollection<TSource> source, bool condition,
            TSource item)
            => source.DoIf(condition, s => s.Remove(item));

        public static bool IsNotEmpty<TSource>(this ICollection<TSource> source)
            => source != null && source.Count != 0;

        public static bool IsEmpty<TSource>(this ICollection<TSource> source)
            => source == null || source.Count == 0;
    }
}