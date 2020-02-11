using System;

namespace DoIf
{
    // https://stackoverflow.com/questions/12465961/is-referenceequalsmyobject-null-better-practice-than-myobject-null
    public static partial class Fun
    {
#pragma warning disable IDE0041
        public static object NullCheck(this object value, string message = "")
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), message);

            return value;
        }

        public static bool IsNull(this object value)
            => ReferenceEquals(value, null);

        public static bool IsNotNull(this object value)
            => !ReferenceEquals(value, null);
#pragma warning restore IDE0041
    }
}