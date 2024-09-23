# Övningsuppgifter med arv och polymorfism

## 1. Skapa en klass för fordon
Skapa en enum Brand med 5 bilmärken, och en enum Color med 5 färger. Skriv sedan en klass Vehicle som har publika properties Brand och Color. Klassen ska ha en konstruktor som man kan använda för att sätta Brand och Color, och en konstruktor som endast tar Brand och sätter en default färg.

## 2. Lägg till override för ToString()
ToString() är en metod som alla klasser ärver från System.Object. Denna metod anropas implicit när man skickar in ett objekt till Console.WriteLine, eller använder ett objekt i en konkatenering (t.ex en interpolation string). Implementationen i System.Object är sådan att den bara skriver ut objektets datatyp, men din klass kan göra en override på ToString() och returnera en sträng i vilket format du vill.

Gör en override på ToString() i Vehicle-klassen, så att "A white Toyota" skrivs ut om man kör följande kod:

```cs
Console.WriteLine(new Vehicle(Brand.Toyota, Color.White));
```

## 3. Skapa en subklass för bilar
Skapa en klass Car som ärver av Vehicle. Lägg till en publik property Model, och skapa en konstruktor som initierar Brand, Model och Color.

"A white Yaris from Toyota" ska skrivas ut om man kör följande kod:

```cs
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
```

## 4. Skapa en struct för att spara längd, bredd och höjd.

Skapa en struct Size med properties Length, Width och Height; samt en konstruktor som tar 3 argument för att initiera dessa.

## 5. Initiera i Vehicle, skriv ut i Car.

Uppdatera Vehicle-klassen så den sätter slumpmässiga (men rimliga) värden för längd, bredd och höjd.

Uppdatera Car-klassen så att även längden skrivs ut när samma kod som i uppgift 3 körs.

Ex: "A white 4.1 meter long Yaris from Toyota".

## 6. Circle som ärver från Shape

Utgå från följande kod:

```cs
public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
}
```

Skapa en klass Circle som ärver från klassen ovan.

Implementera Circle på så vis att koden nedan ...

```cs
var circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");
```

... ger följande utskrift:

```
A circle with radius 5
Area: 78,54
Circumference: 31,42
```

## 7. Square ärver också från Shape

Skapa även en klass Square som ärver från Shape.

Implementera Square på så vis att koden nedan ...

```cs
var square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");
```

... ger följande utskrift:

```
A square with side 5
Area: 25,00
Circumference: 20,00
```

## 8. Lägg till Print() i Shape

Uppdatera (endast) den abstrakta basklassen med en Print() method.

När detta är gjort ska koden nedan ...

```cs
var square = new Square(3.2);
square.Print();

var circle = new Circle(4.5);
circle.Print();
```
... ge följande utskrift:

```
A square with side 3,2 has an area of 10,24 and a circumference of 12,80.
A circle with radius 4,5 has an area of 63,62 and a circumference of 28,27.
```

## 9. En array av cirklar och kvadrater
```cs
Shape[] shapes = new Shape[10];
```

Skriv en loop som slumpmässigt initerar alla element i arrayen med antingen cirklar med 0 < radie < 10, eller kvadrater med 0 < sida < 10.

Sätt en breakpoint efter loopen och inspektera arrayen i Visual Studios debugger.

## 10. Statiska printmetoder
Lägg till en statisk metod PrintAll() i Shape som anropar Print() på alla shapes i en array.

Lägg även till en statisk metod PrintCircles() som endast anropar Print() på alla cirklar i en array.

Prova sedan att köra följande kod:
```cs
Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);
```
(där shapes är arrayen från uppgift 9)

Ovanstående ska skriva ut först alla shapes i arrayen, följt av blankrad, följt av alla circles i arrayen.

## 11. Lägg till färger i PrintAll()
Uppdatera PrintAll() i uppgift 10, så att alla rader med cirklar skrivs med röd färg och alla rader med kvadrater skrivs med grön färg.

## 12. Random färger
Lägg till följande i Shape

```cs
protected ConsoleColor color;
```

Uppdatera sedan subklasserna med en variant (overload) av konstruktorn som även tar en färg. Använd dig av constructor chaining.

Uppdatera PrintAll() så att raden skrivs ut i den färg som angavs när vardera shape skapades.

Uppdatera loopen som initierar arrayen så att varje shape som skapas får en random färg.