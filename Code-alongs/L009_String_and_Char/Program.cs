Console.WriteLine("*** String ***********");

string myString = string.Empty;

myString = "Hello world!";

Console.WriteLine();
Console.WriteLine($"myString = {myString}");

Console.WriteLine($"Length of myString: {myString.Length}");
Console.WriteLine();

Console.WriteLine($"myString.ToLower() => {myString.ToLower()}");
Console.WriteLine($"myString.ToUpper() => {myString.ToUpper()}");

Console.WriteLine($"myString.PadLeft(50, '*') => {myString.PadLeft(50, '*')}");
Console.WriteLine($"myString.PadRight(50, '*') => {myString.PadRight(50, '*')}");

Console.WriteLine($"myString.Substring(4, 3) => {myString.Substring(4, 3)}");
Console.WriteLine($"myString.Remove(4, 3) => {myString.Remove(4, 3)}");
Console.WriteLine($"myString.Insert(4, \"ABC\") => {myString.Insert(4, "ABC")}");

Console.WriteLine($"myString.Replace(\"world\", \"there\") => {myString.Replace("world", "there")}");

Console.WriteLine($"myString.myString.IndexOf('o')) => {myString.IndexOf('o')}");

Console.WriteLine();
Console.WriteLine("*** Char ************");
Console.WriteLine();

Console.WriteLine($"Char.IsDigit('A') => {Char.IsDigit('A')}");
Console.WriteLine($"Char.IsDigit('4') => {Char.IsDigit('4')}");
Console.WriteLine($"Char.IsLetter('A') => {Char.IsLetter('A')}");
Console.WriteLine($"Char.IsLetter('4') => {Char.IsLetter('4')}");
Console.WriteLine($"Char.IsLetterOrDigit('A') => {Char.IsLetterOrDigit('A')}");
Console.WriteLine($"Char.IsLetterOrDigit('4') => {Char.IsLetterOrDigit('4')}");
Console.WriteLine($"Char.IsLetterOrDigit('?') => {Char.IsLetterOrDigit('?')}");

foreach (char c in myString)
{
    Console.WriteLine($"char.IsUpper('{c}') => {char.IsUpper(c)}");
}













