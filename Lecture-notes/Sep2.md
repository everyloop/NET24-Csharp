# September 2

## Funktioner (och Metoder)

**Code-along:**  
[L007_Funktioner](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L007_Funktioner/Program.cs)

Funktioner och Metoder är två snarlika begrepp, med skillnaden att Metoder är knutna till objekt och därför har en annan kontext.

Eftersom vi inte har kommit till objekt än, så håller vi oss till funktioner än så länge. Skillnaden kommer bli tydligare längre fram i kursen.

Det vi lär oss här om funktioner gäller dock (med undantag för *static*) även för metoder, så ni kommer ha mycket med er när vi kommer dit i kursen.

### Definera funktioner
En funktion är ett stycke kod som man definerat upp i förväg och som sedan kan anropas från andra ställen i koden; oftast med olika inparameterar. Detta gör att man enkelt kan återanvända kod, och slipper skriva samma sak om och om igen om samma funktionalitet behövs på flera ställen.

En funktion defineras med **en signatur** som dels talar om namnet på funktionen, dels säger vilka data som kan skickas in via funktionsanrop, samt vilken typ av data man får tillbaka. Funktionssignaturen **följs av ett kodblock** som beskriver vad funktionen gör.

**Exempel:**
``` cs
static string GetFullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}
```
Ovanstående definerar en funktion med namn *GetFullName*, som tar två inparameterar: *firstName* och *lastName*. Funktionen konkatenerar dessa till ett sträng med namnet i helhet och returnerar denna till funktionsanropet.

***OBS!*** *Ta för vana att alltid definera dina lokala funktioner med keyword ***static***, som ovan, då detta förhindrar att funktionen kan använda externa variabler, och alltså garanterar att funktionen är oberoende av annan kod än sin egen. (Keyword static betyder dock något annat när man skapar metoder, men vi återkommer till det).* 

### Anropa funktioner
För att funktionen ovan ska köras krävs att den anropas någonstans. Definitionen i sig körs aldrig utan anrop. Ett anrop består av namnet på funktionen följt av paranteser med eventuella argument (indata).

**Exempel**
``` cs
string name = GetFullName("Fredrik", "Johansson");
```
Ovanstående kod anropar funktionen *GetFullName()* med argumenten *"Fredrik"* och *"Johansson"* och tilldelar resultatet, d.v.s strängen som funktionen returnerar, till variablen *name*.

### Parametrar & Argument
Parameterar anges inom parantes i funktionens signatur, och anger vilken data som kan skickas in i funktionen vid anrop. En funktion kan ha noll, en, eller flera parametrar. Dessa anges som en kommaseparerad lista där varje parameter beskriv av en datatyp följt av ett namn.

Argument kallas de värden som skickas in vid själva anropet till funktionen. Argumenten måste matcha funktionens parametrar till antal och datatyp(er).

### Returvärden
En funktion kan returnera noll eller ett (men inte flera) värde tillbaks till koden som gjorde anropet.

Datatypen som funktionen returnerar anges i signaturen, före funktionsnamnet. Om funktionen inte returnerar något värde alls anges istället keyword **void** på den plats där datatypen annars står.

## Call stack
Allmäna begrepp inom datavetenskap:

- En **datatyp** beskriver vilken typ av data som ett enskilt värde (t.ex en variabel) är. (text, heltal etc.)
- En **datastruktur** beskriver hur flera värden (datapunkter) struktureras till en större helhet.

En **stack** är en datastruktur där nya värden alltid läggs till i slutet på redan existerande värden i "stacken", och när man läser ett värde från "stacken" så är det alltid det senaste skrivna (detta plockas då samtidigt bort ur "stacken"). Detta kallas ibland även för en LIFO (Last In, First Out).

Under körning så använder .NET runtime internt så kallad **call stack** för att hålla reda på vilken del av koden som ska anropas härnäst. Så länge statements bara körs efter varandra (utan funktionsanrop) så kommer det finnas ett värde längst ner i *call stack* som uppdateras för att hela tiden peka på nästa rad.

När programmet däremot hoppar in i en funktion, så läggs ett nytt värde överst på *call stack* som uppdateras när programmet stegar vidare. Samtidigt ligger alla referenser till *varifrån* funktionen anropas kvar längre ner i stacken, så att runtime vet vart den ska hoppa "tillbaks" efter en funktion körts klart.

I Visual studio kan man öppna ett fönster i debug-läget som visar call stacken, så man alltid kan se exakt vilken väg programmet tagit för att komma till ett visst ställe i koden.

## Rekursiva anrop

**Code-along:**  
[L008_Rekursiva_anrop](https://github.com/everyloop/NET24-Csharp/blob/master/Code-alongs/L008_Rekursiva_anrop/Program.cs)

Ett rekursivt anrop är när en funktion eller metod anropar sig själv (alternativ två eller fler funktioner som anropar varandra). Om funktionen/funktionerna inte har något vilkor för när dessa anropen ska sluta så kommer programmet hamna i en "evig" loop, och ganska snabbt krasha för att minnet i call stacken tar slut (eftersom man fortsätter lägga till värden för varje anrop, som aldrig plockas bort då ingen funktion avslutas.)

### Undvik rekursiva anrop
Rekursiva anrop *kan* användas för att lösa olika typer av problem. Dessas problem kan dock lösas även utan rekursiva anrop, vilket ofta ger mer lättbegriplig kod.

Min rekommendation är att ni helt undviker att använda rekursiva anrop, eftersom dessa oftast gör koden krångligare; specielt om man är ny på programmering.

Är man ändå intresserad av att förstå hur de fungerar så kan man hitta övningar på rekursiva anrop t.ex. [här](https://www.exercisescsharp.com/recursion/)

## Riktlinjer för att skriva tydlig kod

Kod är främst kommunikation med andra människor.

"Make reading easy, even if it makes writing harder."

"Later equals never."

"There is nothing as permanent as a temporary solution."

### DRY - "Don't Repeat Yourself".
Man vill unvika upprepad kod. Så, om man upptäcker att man har samma kod upprepad om och om igen, flytta ut den i funktioner t.ex.

### Kommentar i kod
Kod ska i största möjliga mån vara självförklarande.

Kommentarer bör endast förklara varför, inte hur.

### Namngivning
Att ge tydliga och beskrivande namn på variabler, metoder, funktioner, klasser etc, är en av de viktigaste sakerna man kan göra för att göra koden mer lättläst.

[Vi fortsätter prata om detta 25:e September](https://github.com/everyloop/NET24-Csharp/blob/master/Lecture-notes/Sep25.md)


