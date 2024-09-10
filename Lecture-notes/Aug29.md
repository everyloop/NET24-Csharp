# Augusti 29

## Debugging (Felsökning)

Det finns 3 olika kategorier av fel som vi kan ha i våran kod.

### Syntax error (Kompileringsfel)
Koden är felskriven så att kompilatorn inte förstår och inte kan bygga ditt program. I detta fall så får man en lista över alla fel i koden, med beskrivning av felet, samt i vilken fil och rad felet är. 

Denna typ av fel är de enklaste att upptäcka och fixa. Googla felmedelandet, eller kolla upp i dokumentation.

### Runtime error (Exekveringsfel)
Koden är "korrekt" så tillvida att programmet kompilerar, men programmet "krashar" under körning, med ett felmeddelande.

Denna typ av fel kastar en "exception". Vilket vi går igenom [9:e September](https://github.com/everyloop/NET24-Csharp/blob/master/Lecture-notes/Sep9.md)

### Logical errors (Logiskt fel)
Programmet kompilerar och startar, och det krashar inte heller. Men, resultatet av programmet är inte det förväntade.

## Arrayer

**Code-along:**  
[L005_Arrays](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L005_Arrays/Program.cs)

**Tutorials:**  
[Array](https://www.tutorialsteacher.com/csharp/array-csharp)  
[Multidimensional array](https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array)  
[Jagged array](https://www.tutorialsteacher.com/csharp/csharp-jagged-array)  

## Foreach
Foreach är en typ av loop som används för att iterera igenom alla element i en array, eller andra dataset (t.ex alla tecken i en sträng). 

Loopens kodblock körs då en gång ***för varje*** element i arrayen, Foreach har en lokal variabel som för varje iteration tilldelas nästa elements värde, ända tills man gått igenom alla värden i arrayen.

Till skillnad från när man använder en for-loop behöver man alltså inte använda indexering för att få ut värdena från de enskilda elementen.

**Exempel:** Utskrift av alla bilar i arrayen *cars*.
``` cs
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string car in cars) 
{
  Console.WriteLine(car);
}
```

Den lokala variabeln (car) är alltid read-only. Det betyder att med en foreach kan man aldrig uppdatera data i datasetet man loopar igenom. Vill man uppdatera behöver man istället använda en for-loop och indexering.

[Läs mer här!](https://www.programiz.com/csharp-programming/foreach-loop)

## Strängar
**Code-along:**  
[L006_Strings](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L006_Strings/Program.cs)

### Indexerbara
Strängar i C# är indexerbara, d.v.s man kan komma åt enskilda tecken (datatyp Char) med hjälp av index, på samma sätt som man kan komma åt enskilda element i en array. Till skillnad från en char[] så är kan man inte skriva till (ändra) den enskilda tecknen i en array genom indexering; de är read-only.

### Escape sequences

Teckenkombinationer som består av ett backslash följt av ett annat tecken kallas för "escape sequences". De används för att i kod representera t.ex, radbyte, tab, citattecken och andra tecken som man annars inte kan skriva i en vanlig string literal.

[Läs mer här!](https://learn.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170)

### Interpolation strings

String interpolation är en metod för att konkatenera, formatera och manipulera strängar.

``` cs
int operand1 = 5;
int operand2 = 7;

// Interpolation strings starts with a $
string myString = $"{operand1} + {operand2} = {operand1 + operand2}";
```
[Läs mer här!](https://www.c-sharpcorner.com/article/understanding-string-interpolation-in-c-sharp/)
