namespace L037_Library
{
    public static class StringExtensions
    {
        public static int WordCount(this string s)
        {
            return s.Split(' ').Length;
        }

        public static string Encapsulate(this string s, string enclosure)
        {
            return enclosure + s + enclosure;
        }

        public static string Encapsulate(this string s, string prefix, string suffix)
        {
            return prefix + s + suffix;
        }
    }
}
