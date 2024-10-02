
Func<int, int> square = a => a * a;
Action<int> printInt = x => Console.WriteLine(x);

Func<Person, int, bool> isLegal = (person, legalAge) => person.Age >= legalAge;

printInt(square(5));

Console.WriteLine(isLegal(new Person() { Age = 15}, 18));

Console.WriteLine("*************'");
PrintResult(MultiplyBy10, 5);

static int MultiplyBy10(int x)
{
    return x * 10;
}

static void PrintResult(Func<int, int> func, int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}: {func(i)}");
    }
}

static int Square(int a)
{
    return a * a;
}

static void PrintInt(int x)
{
    Console.WriteLine(x);
}

class Person
{
    public int Age { get; set; }
}