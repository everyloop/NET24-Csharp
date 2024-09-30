
// DemoDelegate myDelegate = new DemoDelegate(CharCounter);
using System.Globalization;

Func<string, int> myDelegate = WordCounter;

//Console.WriteLine(myDelegate.Invoke("Hello world!"));
Console.WriteLine(myDelegate("Hello world!"));

myDelegate = CharCounter;

Console.WriteLine(myDelegate("Hello world!"));

myDelegate = null;

// Krashar om myDelegate är null
// Console.WriteLine(myDelegate("Hello world!"));

// Krashar INTE om myDelegate är null
Console.WriteLine(myDelegate?.Invoke("Hello world!"));

Console.WriteLine();

string[] strings = new string[] { "hello world", "hi there everyone", "denmark" };

ProcessStrings(strings, CharCounter);

Console.WriteLine();

ProcessStrings(strings, WordCounter);


static void ProcessStrings(string[] strings, Func<string, int> demoDelegate)
{
    foreach (string s in strings)
    {
        Console.WriteLine(demoDelegate?.Invoke(s));
    }
}

static int CharCounter(string text)
{
    return text.Length;
}

static int WordCounter(string text)
{
    return text.Split(' ').Length;
}

static void PrintHello()
{
    Console.WriteLine("Hello");
}

//public delegate int DemoDelegate(string s);

// Använd generiska delegat (Func (returvärde), Action (inget returvärde)) för att lösa följande uppgifter:
// Func<in T1, in T2, ..., out TResult>
// Action<in T1, in T2, ...>

// Miniuppgift 1:
// Skapa en funktion som tar två heltal in, plussar ihop dem, och skriver ut resultatet. Skapa ett generiskt delegat som pekar på metoden
// och använd detta för att anropa metoden.

Console.WriteLine();
Console.WriteLine("Uppgift 1:");
Action<int, int> addDelegate = Add;

addDelegate(3, 4);

static void Add(int a, int b)
{
    Console.WriteLine(a + b);
}

// Miniuppgift 2:
// Skapa en funktion som tar en Char och en Int in, samt returnerar en String som innehåller bokstaven upprepad det antal gånger som man
// angett i heltalet. Använd ett generiskt delgat för att anropa metoden. Skriv ut resultatet.

Console.WriteLine();
Console.WriteLine("Uppgift 2:");
Func<char, int, string> stringDelegate = GetString;
Console.WriteLine(stringDelegate('a', 5));

static string GetString(char c, int i)
{
    return new String(c, i);
}

// Miniuppgift 3:
// Skriv en funktion som tar två heltal in, multiplicerar dem och skriver ut resultatet. Skriv sedan ytterligare en funktion som tar 
// in ett heltal tillsammans med ett delgat till en metod som tar två heltal in. Om man skickar in t.ex 3 till denna metoden så ska den ha
// loop i från 1 till 10, som varje gång anropar delegatmetoden med (3, i). Prova att anropa metoden dels med funktionen i uppgift 1, dels
// med funktionen som multiplicerar.


Console.WriteLine();
Console.WriteLine("Multicast delegates");

static void FuncA()
{
    Console.WriteLine("FuncA");
}

static void FuncB()
{
    Console.WriteLine("FuncB");
}

static void FuncC()
{
    Console.WriteLine("FuncC");
}

Action action = FuncA;
action += FuncB;
action += FuncC;
action += FuncB;
action += FuncB;
action += FuncA;

action.Invoke();