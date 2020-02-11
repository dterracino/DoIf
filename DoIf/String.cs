using static System.String;

namespace DoIf
{
    // https://stackoverflow.com/questions/6976597/string-isnulloremptystring-vs-string-isnullorwhitespacestring
    public static partial class Fun
    {
        public static bool IsEmpty(this string value)
            => IsNullOrEmpty(value);

        public static bool IsNotEmpty(this string value)
            => !IsNullOrEmpty(value);

        public static string ToNotNullString(this object value)
            => value + Empty;
    }
}