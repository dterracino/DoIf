using System.Text;

namespace DoIf
{
    public static partial class Fun
    {
        public static StringBuilder AppendIf<TSource>(this StringBuilder stringBuilder, bool condition, TSource value)
            => stringBuilder.DoIf(condition, sb => sb.Append(value));

        public static StringBuilder AppendIf(this StringBuilder stringBuilder, string value)
            => stringBuilder.DoIf(!string.IsNullOrEmpty(value), sb => sb.Append(value));

        public static StringBuilder AppendLineIf(this StringBuilder stringBuilder, bool condition, string value)
            => stringBuilder.DoIf(condition, sb => sb.AppendLine(value));

        public static StringBuilder AppendLineIf(this StringBuilder stringBuilder, string value)
            => stringBuilder.DoIf(!string.IsNullOrEmpty(value), sb => sb.AppendLine(value));

        public static StringBuilder ClearIf(this StringBuilder stringBuilder, bool condition)
            => stringBuilder.DoIf(condition, sb => sb.Clear());
    }
}