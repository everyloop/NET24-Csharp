
// Klasser & Objekt kan ha olika typer av "members":
// 1. Metoder = Kod som körs när man anropar metoden.
// 2. Properties = En "variabel" som är kopplad till ett objekt.

//Console.WriteLine("Hello");
//string myString = "my string";
//Console.WriteLine(myString.ToUpper());

// Funktioner & Metoder.

// DRY: Don't Repeat Yourself.

// .NET Använder en Call Stack för att hålla reda på varifrån olika funktioner/metoder anropas 

//static void MyFunction()
//{
//    for (int i = 0; i <= 9; i++)
//    {
//        Console.Write(i);
//    }
//    Console.WriteLine();
//}

//static void FunctionA()
//{
//    Console.WriteLine("Här startar funktion A");
//    Console.WriteLine("AAAAAAAAAAAAAA");
//    Console.WriteLine("Här slutar funktion A");
//    int[] myArray = new int[3];
//    myArray[10] = 5;
//}

//static void FunctionB()
//{
//    Console.WriteLine("Här startar funktion B");
//    FunctionA();
//    Console.WriteLine("Här slutar funktion B");
//}

//FunctionB();
//FunctionA();
//FunctionB();

// Stack, skriver alltid senaste värde till "toppen", och plockar alltid bort (läser) värden i bakvänd ordning.


int x = 3;

// En funktion kan ta 0, 1 eller flera parameterar.
// Varje parameter har en egen datatyp.
static void MyFunction(int a, int b, string s = "")
{
    Console.WriteLine(a + b);
    Console.WriteLine(s);
    Console.WriteLine();
}

// Vid funktionsanrop måste argumenten stämma i antal och datatyp med funktionens parameterar.
MyFunction(8, 2, "Hello");
MyFunction(6, x, "World");
MyFunction(x, x);

// Miniuppgift 1:
// Skriv en funktion Greet() med en parameter för namn.
// När man anropar funktionen så skriver den ut en hälsning t.ex "Hi, Fredrik".

// Miniuppgift 2:
// Uppdatera funktioen ovan så den även kan ta en "optional" parameter som säger hur många gånger den ska skriva hälsningen.
// D.v.s om man t.ex anropar med Greet("Fredrik", 5); så skriver den "Hi, Fredrik!" fem gånger.

Console.WriteLine("************");

static void Greet(string name, int loops = 1)
{
    for (int i = 0; i < loops; i++)
    {
        // Console.WriteLine("Hej " + name + "!");
        Console.WriteLine($"Hej {name}!");
    }
}

Greet("Fredrik");
Greet("Anna", 4);

Console.WriteLine("************");

static string GetFullName(string firstName, string lastName)
{
    if (firstName.Length < lastName.Length)
    {
        return firstName;
    }
    else if (firstName.Length > lastName.Length)
    {
        return lastName;
    }

    return $"{firstName} {lastName}";
}

Console.WriteLine(GetFullName("Fredrik", "Johansson".ToUpper()));
Console.WriteLine(GetFullName("Fredrik", "Ek"));
Console.WriteLine(GetFullName("Anna", "Palm"));

Console.WriteLine("Hello".ToUpper());



