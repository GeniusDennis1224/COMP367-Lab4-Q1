namespace StringLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string str)
        {
            return !string.IsNullOrEmpty(str) && char.IsUpper(str[0]);
        }
    }
}
