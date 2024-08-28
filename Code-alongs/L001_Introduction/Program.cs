
// Statement, Sats
// Ex: Console.WriteLine();

// Expression, Uttryck 
// Ex 5 + 3, x == 5

// Variabler och datatyper
int myInteger = 5; // Integer, Heltal
double myDouble = 5.7; // Flyttal med dubbel precision.
bool myBool = true; // Boolean, kan lagra exakt två värden: true eller false.
string myString = "Hello world!"; // Lagrar sträng (text).
char myChar = 'w'; // Lagrar ett enskilt tecken.

// Literal value (Exakt/hårdkodat värde) 
// Ex: "Hello world!", 5.3, true

// Suffix (tillägg efter ett literal value för att hinta för kompilatorn vilken datatyp det är).
var myVar = 5l;
var myVar2 = 5.3m;

// Null-värde (Keyword null)
myString = null;

// C# är ett statiskt typat språk (statically typed language)
// C# är även ett starkt typat språk (strongly typed language)
// myInteger = "Hej"; <= Det går inte att tilldela en variable av typ int, t.ex ett sträng-värde.

// C# är ett typsäkert språk.
Console.WriteLine(3 + 50);       // <= + betyder addition när man gör det mellan heltal. 
Console.WriteLine("3" + "50");   // <= + betyder konkatenering när man gör det mellan strängar.
Console.WriteLine("hello world!".ToUpper());
// Console.WriteLine(523.ToUpper()); <= Strängmetoder går inte att köra på andra datatyper.

// Explicit (Uttryckligen) och implicit (Underförstått) typade variabler.
// Keyword: var
// Oavsett vilket (explicit eller implicit) så är c# statiskt typat, d.v.s. den måste veta datatype
// vid compile-time. Använder du var, så säger du till kompilatorn att själv lista ut vad du menar.
var myVariable = "hello"; 
Console.WriteLine(myVariable);

// Scope (Livstid på variable, d.v.s hur länge är den giltig.
// Class level scope
// Method level scope
// Block level scope

var i = 0;

Console.WriteLine(i);
if (3 < 5)
{
    Console.WriteLine(i);
    i = 5;
    Console.WriteLine(i);
}
Console.WriteLine(i);


Console.WriteLine();
Console.WriteLine("------------------------");
Console.WriteLine();

// Arithmetic Operators
// Plus (+), minus (-), gånger (*), division (/)
// Remainder (%)
// Increase by 1 (++), Decrease by 1 (--) 
// +=, -=, *=, /=, %=

Console.WriteLine(11 / 3); // När både täljare och nämnare är heltal blir resultat heltal, annars flyttal
Console.WriteLine(11 % 3); // Modulus (mod) operatorn ger oss det som blir över.
Console.WriteLine();

int i2 = 5;
Console.WriteLine(--i2);
Console.WriteLine(i2++);
Console.WriteLine(++i2);

Console.WriteLine();
int i4 = 5;
i4 *= 3; // i4 = i4 * 3;
Console.WriteLine(i4);

// Assignment operator
// Ett enkelt likamed tecken använd för att tilldela en variabel ett värde.
int i3 = i2;
Console.WriteLine(i3);
Console.WriteLine();

// Equality operators
Console.WriteLine(5 == 3);
Console.WriteLine(5 != 3);

Console.WriteLine();

// Comparison operators
Console.WriteLine(5 < 3);
Console.WriteLine(5 > 3);
Console.WriteLine(5 <= 3);
Console.WriteLine(5 >= 3 + 5);

Console.WriteLine();

// Boolean logical operators
Console.WriteLine(!true);
Console.WriteLine(5 < 3 && 7 > 4);
Console.WriteLine(5 < 3 || 7 > 4);

Console.WriteLine();
Console.WriteLine((3 + 2) * 2);











