internal class Program
{
    // När .NET runtime laddat in ditt program kommer den leta igenom alla klasser tills den hittar
    // en statisk metod med namnet "Main". Denna används som entry point till ditt program genom att
    // runtimen anropar metoden, och skickar med de argument som användes i command line vid start.

    // Det måste allstå finnas exakt en (1) statisk metod med namn "Main".

    private static void Main(string[] args)
    {
        Console.WriteLine($"This program was invoked with the following {args.Length} command line arguments:");
        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        Console.WriteLine();

        int x = 3;
        StaticLocalFunctionPrintHello(x);
        NonStaticLocalFunctionPrintHello();
        StaticMethodPrintHello();

        // Detta är inte en metod, d.v.s det är ingen member på klassen "Program".
        // Detta är istället en så kallad "local function" som man kan bädda in i en metod,
        // och som endast kan anropas inifrån metoden den ligger i.

        // För en "local function" har keyword static en något annorlunda betydelse:
        // Om den är static kan den inte komma åt variabler som är definerad i den omslutande metoden.
        static void StaticLocalFunctionPrintHello(int y)
        {
            Console.WriteLine($"Hello! => {y}");
        }

        void NonStaticLocalFunctionPrintHello()
        {
            Console.WriteLine($"Hello! => {x}");
        }

    }

    // Eftersom Main() är statisk, så kan den bara anropa andra metoder i klassen som också är statiska.
    private static void StaticMethodPrintHello()
    {
        Console.WriteLine("Hello!");
    }

}

// I C# 9.0 introducerades dock top level statements, som gör att man kan ha en (1) fil i sitt projekt
// där kod inte ligger i en klass. D.v.s filen med top level statement kan t.ex ha endast t.ex en
// Console.Write() och ändå fungera; Det kompilatorn gör när den hittar top level statements är att
// den automatisk skapar en klass med en Main metod vid kompilering och lägger alla top level statements
// i denna. Det blir alltså ingen skillnad i det färdigbyggda programmet oavsett om man använder sig
// av top level statements eller inte.
