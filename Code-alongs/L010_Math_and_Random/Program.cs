// See https://aka.ms/new-console-template for more information
Console.WriteLine($"PI = {Math.PI}");
Console.WriteLine($"e = {Math.E}");

Console.WriteLine($"Math.Abs(5) = {Math.Abs(5)}");
Console.WriteLine($"Math.Abs(-5) = {Math.Abs(-5)}");

double value = 5.5;
Console.WriteLine($"Math.Floor({value}) = {Math.Floor(value)}");
Console.WriteLine($"Math.Ceiling({value}) = {Math.Ceiling(value)}");
Console.WriteLine($"Math.Round({value}) = {Math.Round(value)}");
Console.WriteLine($"Math.Truncate({value}) = {Math.Truncate(value)}");

Console.WriteLine($"Math.Min(5.23) = {Math.Min(5.23, 6.07)}");
Console.WriteLine($"Math.Max(5.23) = {Math.Max(5.23, 6.07)}");
Console.WriteLine($"Math.Clamp(5.23, 6.07, 9.3) = {Math.Clamp(5.23, 6.07, 9.3)}");

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Math.Clamp({i}, 3, 8) = {Math.Clamp(i, 3, 8)}");
}

Console.WriteLine();
Console.WriteLine($"Math.Pow(2, 3) = {Math.Pow(2, 3)}");
Console.WriteLine($"Math.Sqrt(9) = {Math.Sqrt(9)}");

Console.WriteLine();
Console.WriteLine("*** Random ***************");
Console.WriteLine();

Random rand = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{rand.Next(), 12}");
}













