using L037_Library;

string text = "Hi there everyone";
Console.WriteLine(text.WordCount());

Console.WriteLine("Hello, World!".Encapsulate("***"));
// Skriv en extension method där resultatet av ovanstående kod blir: "***Hello, World!***"

// Skriv en variant av Encapsulate som tar 2 parameterar
Console.WriteLine("Hello, World!".Encapsulate("<<", ">>"));
// Ovanstående ska då skriva ut: "<<Hello, World!>>"

// Vi har lagt nedanstånde kod i L037 för att visa hur class library projekt fungerar.
/*
static class StringExtensions
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
*/
