using System;

namespace NetFramework
{
    public static class StringExtension
    {
        public static Boolean EqualsIgnoreCase(this String value, String comparingValue)
        {
            return value.Equals(comparingValue, StringComparison.CurrentCultureIgnoreCase);
        }

        public static Boolean IsNotNullOrEmpty(this String value)
        {
            return !String.IsNullOrEmpty(value);
        }
    }
}
