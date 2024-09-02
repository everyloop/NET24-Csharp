using System.Diagnostics.Metrics;

static void Variabler7()
{
    // Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till 
    // man skriver något som inte är ett tal(t.ex bara trycker enter).Efter varje inmatning 
    // ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas.
    // Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.

    double amountNumbers = 0.0;
    double totalSum = 0.0;

    Console.Write("Enter a number: ");
    string input = Console.ReadLine();

    while (double.TryParse(input, out double parsedInput))
    {
        amountNumbers++;
        totalSum += parsedInput;
        Console.WriteLine(totalSum);

        Console.Write("Enter a number: ");
        input = Console.ReadLine();
    }

    Console.WriteLine();
    double average = totalSum / amountNumbers;
    Console.WriteLine($"Average is {average}");
}

// Variabler7();

static void Loopar6()
{
    // Enligt legenden så fick den man som hade konstruerat det formidabla spelet schack önska sig
    // något värdefullt av den överförtjuste kungen.Monarken blev förvånad över uppfinnarens
    // anspråkslöshet när gåvan skulle bestå av riskorn.

    // Antalet riskorn bestämdes enligt följande regel: ett korn skulle lämnas för första rutan
    // på ett schackbräde, två korn för andra rutan, fyra för tredje, åtta för fjärde och så ändå
    // till den sista rutan.

    // Skriv ett program som hjälper kungen att beräkna antalet riskorn på vardera ruta.

    ulong rice = 1;

    for (int i = 1; i <= 64; i++)
    {
        Console.WriteLine($"Ruta {i}: {rice}");
        rice *= 2;
    }
}

static void Loopar6_alt2()
{
    for (int i = 1; i <= 64; i++)
    {
        var rice = Math.Pow(2, i);
        Console.WriteLine($"Ruta {i}: {rice}");
    }
}

static void indexes10()
{
    // Skapa ett program som ber användaren mata in en text. Be sedan användaren mata in en bokstav.
    // Skriv ut strängen som matades in; de bokstäver som är samma som den användaren valde ska
    // skriva ut med röd färg, alla andra med grå..

    Console.WriteLine("Hej! mata in en text");
    string fras = Console.ReadLine();

    Console.WriteLine("Skriv en bokstav som finns i det du nyss skrev.");
    // Tar första bokstav från inmatning, men kanske bättre ur användareperspektiv att
    // be användaren skriva in på nytt om man skrivit in flera tecken.
    char bokstav = Console.ReadLine()[0];
 
    foreach (char myChar in fras)
    {
        // Ternary operator
        Console.ForegroundColor = (myChar == bokstav ? ConsoleColor.Red : ConsoleColor.Gray);
        Console.Write(myChar);
    }
}

indexes10();