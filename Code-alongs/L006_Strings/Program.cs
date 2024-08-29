
// Strängar går att indexera. De fungerar som en read-only array av Char.

string myString = "Hello world";

// Få ut längden på myString som heltal.
Console.WriteLine(myString.Length);

Console.WriteLine();

// Loopa igenom bokstav för bokstav med index.
for (int i = 0; i < myString.Length; i++)
{
    Console.WriteLine(myString[i]);
}

Console.WriteLine("***********");

// Loopa igenom bokstav för bokstav med foreach
foreach (char minBokstav in myString)
{
    Console.WriteLine(minBokstav);
}

char myChar = 'x';

Console.WriteLine("**********");
Console.WriteLine();

// Standard string literal
Console.WriteLine("Hello\n\"world\"." + myChar);
Console.WriteLine();

// Verbatim string literal startar med @
Console.WriteLine(@"Hello\n""world.");
Console.WriteLine();

// Interpolation strings startar med $
Console.WriteLine($"Värdet på myChar är '{myChar}'");

