# September 23

## Arv

Arv är ett av de grundläggande attributen för objektorienterad programmering. Du kan definiera en underordnad klass som återanvänder (ärver), utökar eller ändrar beteendet för en överordnad klass. Klassen vars medlemmar ärvs kallas för basklassen. Klassen som ärver medlemmarna i basklassen kallas för den härledda klassen.

C# och .NET stöder endast enskilt arv . En klass kan alltså bara ärva från en enda klass. Arv är dock transitivt, vilket gör att du kan definiera en arvshierarki för en uppsättning typer. Med andra ord kan typen Cat ärva från typen Mammal, som ärver från typen Animal, som ärver från basklasstypen Object. Eftersom arv är transitivt är medlemmarna av typen Object tillgängliga för att skriva Cat.

![Arv](https://github.com/everyloop/NET24-Csharp/blob/master/Lecture-notes/Images/Arv.png)

Arv är en is-a-relationship, vilket betyder att ett objekt av typen Cat, även är en Mammal, Animal och Object. En referens till ett objekt av typ Animal kan även hålla objekt av typer som ärver av Animal (eftersom även dessa *är* Animal). På så vis kan vi ha t.ex en array Animal[] som har objekt av såväl Cat, Dog, Sparrow och Parrot.

[Läs mer om arv här!](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/inheritance)

## Polymorfism

Polymorfism betyder "många former", och som namnet antyder så betyder det att vi kan ha flera olika versioner av t.ex metoder i vår kod, och att "rätt" metod väljs när vi gör ett anrop.

Ta exemplet med arrayen Animal[] ovan: eftersom alla som ärver av Animal har en Eat() metod så kan vi anropa Eat() på alla objekt i arrayen; vilken implementation av metoden som faktiskt körs beror på den exakta datatypen. Eat() kan alltså, men måste inte, implementeras olika på objekt av typerna Cat, Dog, Sparrow, respektive Parrot.

[Läs här!](https://www.studytonight.com/post/csharp-polymorphism)

[Läs mer här!](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism)


## Cast and conversion

[Läs här!](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)



