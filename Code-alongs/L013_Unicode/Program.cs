// char representerar ett (1) tecken.
char myChar = 'A';

// Man kan även ange ett tecken i Unicode genom escape sequence som börjar på \u följt av 4 hexadecimala siffror (d.v.s. 16 bitar).
myChar = '\u0041';

// Man kan konvertera en char till int för att få ut det Unicode-nummer som representerar tecknet.
Console.WriteLine($"Unicode för '{myChar}' är {(int)myChar}.");

Console.WriteLine();

// Man kan även konvertera int till char för att få det tecken som representeras av ett givet nummer i Unicode.
for (int i = 65; i < 65 + 26; i++)
{
    Console.Write((char)i);
}

Console.WriteLine();
Console.WriteLine();

string name = "Fredrik";

foreach (char c in name)
{
    Console.WriteLine($"Unicode för '{c}' är {(int)c}.");
}
