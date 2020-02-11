using System;

namespace DoIf
{
    public static partial class Fun
    {
        public static TSource DoIf<TSource>(this TSource source, bool condition, Action<TSource> action)
        {
            if (condition)
                action(source);

            return source;
        }

        public static TSource DoIf<TSource>(this TSource source, bool condition, Func<TSource, TSource> func)
            => condition ? func(source) : source;
    }
}
