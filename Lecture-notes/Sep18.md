# September 18

Repetition och fördjuping av objektorienterad programmering.

## Klass

En klass är en definition av en datatyp.

Man kan också säga att en klass är en modell eller "blueprint" över hur en given typ av objekt fungerar; dess egenskaper och metoder.

## Objekt

Ett objekt eller instans, är en enskild representation av en given typ (klass).

Vi kan t.ex definera en klass "Cat" som fungerar som en modell över vilka egenskaper och metoder en katt har. Efter att vi definerat klassen, så kan vi skapa ett godtyckligt antal objekt av typen "Cat". Dessa objekt fungerar fristående från varandra och var och ett håller sin egen data. Det enda de har gemensamt är just att de är av samma typ, d.v.s de har samma uppsättning "members".

## Members

Klasser har "members" som representerar dess data och funktionalitet.

Några exempel på "members" är: "fields", "properties" och "methods".

Fields och properties kan betraktas som variabler knutna till en enskild instans av en klass. Man kan alltså lagra och hämta data från dessa. Fields och properties skiljer sig dock i hur de hanteras internt.

Metoder är anropbar kod knutna till ett objekt.

## this

I C# används keyword "this" för att referera till den instans av klass som har anropat en av klassens metoder.

## null

Keyword null används som en literal value för att indikera att en referens inte pekar på något faktiskt objekt.

Man kan använda [null-conditional operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-) för att säkerställa att programmet inte krashar om referensen är null när man försöker komma åt en member.

## Method overloading

Flera metoder i en klass kan ha samma namn fast med olika (i antal eller typ) parametrar. Detta är en typ av polymorfism. (Poly = Många, Morph = Former). Med andra ord: Method overloading låter oss skapa flera olika former av samma metod. Vilken av implementationerna som faktiskt körs avgörs vid kompilering genom att kolla på vilka argument som skickas in vid anropet.

## Static classes and members

[Läs mer här!](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)

## Top level statements

Top level statements introducerades i C# 9. Innan dess behövde alla program alltid innehålla en explicit Main-metod som var appens entry point.

[Läs mer här!](https://www.thomasclaudiushuber.com/2020/08/18/c-9-top-level-statements-or-should-i-say-hey-wheres-the-main-method/)

Se även längre förklaring i kommentarerna i denna code-along:

**Code-along:**  
[L019_Main_method_entry_point](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L019_Main_method_entry_point/Program.cs)

## Namespaces

[Läs här!](https://www.tutorialspoint.com/csharp/csharp_namespaces.htm)

**Code-along:**  
[L020_Namespaces_and_Using](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L020_Namespaces_and_Using/Program.cs)

## Konstruktor




